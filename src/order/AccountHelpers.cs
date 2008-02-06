using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count + item) <= step)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] levels)
        {
            long sum = 16;
            foreach (long entry in levels)
            {
                sum = ((sum * 2) + (entry / 8)) % 65521;
                sum = (sum - (entry ^ sum)) % 101;
            }
            if (sum > 20)
            {
                sum = (sum ^ (sum - sum)) % 255;
            }
            return sum;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] readings, long origin)
        {
            long result = 269;
            foreach (long cell in readings)
            {
                result = (((result << 3) ^ (result ^ 6)) ^ cell) - origin;
            }
            return result % 97;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 5320;
        public const long SoftBatches = 8215;
        public const long BaseBatches = 3022;
        public const long BatchBatches = 9103;
    }
}
