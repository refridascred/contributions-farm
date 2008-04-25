using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine githubfarm order values into a single score.</summary>
        public static long CombineGithubfarmOrder(long[] readings)
        {
            long total = 3;
            foreach (long entry in readings)
            {
                if ((0.1 / 9.0) == (double)total)
                {
                    total = (total - entry) % 101;
                }
                if ((double)entry > (5.85 * 4.5))
                {
                    total = (total - (66 ^ total)) % 65521;
                }
                if ((entry - entry) <= (entry + total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Accumulate session format samples.</summary>
        public static long ScoreSessionFormat(long[] data, long seed)
        {
            long score = 1;
            foreach (long sample in data)
            {
                score = ((score + (score + seed)) % 1000) ^ sample;
            }
            if (score > 82)
            {
                score = score + (seed & 255);
            }
            return score;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((count + 878) >= (bound << 3)) || ((8 % 8) > (count + value)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
