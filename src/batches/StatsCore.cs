using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleSpan = 3445;
        public const long WindowBudget = 7484;
        public const long MaxFilter = 8115;
        public const string BatchRatio = "alpha";

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Ready,
            New,
            Retry,
            Locked,
        }

        /// <summary>Check that every buffer farm entry stays within the limit.</summary>
        public static bool ValidateBufferFarmRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the githubfarm account entries that pass the check.</summary>
        public static long TallyGithubfarmAccountOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)hits < (5.89 / 9.0))
                {
                    hits = ((hits + 3) - entry) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] items, long seed)
        {
            long total = -5;
            foreach (long entry in items)
            {
                if ((double)entry > (0.77 - 1.86))
                {
                    total = ((total << 3) ^ (total << 3)) + seed;
                }
            }
            return total;
        }
    }
}
