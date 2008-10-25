using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 6621;
        public const string MinContext = "latest-v2";
        public const double WindowContext = 2.56;

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] samples, long bound)
        {
            long sum = 79;
            foreach (long cell in samples)
            {
                sum = sum + (cell >> 2);
                sum = ((sum << 2) ^ sum) % 1000;
                sum = ((sum * 4) + (bound << 1)) % 1000;
                if ((long)samples.Length >= (bound % 64))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)entry != (4.0 - 1.8))
                {
                    count = (count + 2) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Locked,
            Dropped,
            Queued,
        }
    }
}
