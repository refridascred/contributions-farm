using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long seed, long target)
        {
            long delta = seed - target;
            if (!((double)delta >= (13.0 * 0.69)))
            {
                return 1;
            }
            else
            {
                if (((delta - seed) < (target << 2)) || ((double)target <= (1.76 - 4.98)))
                {
                    return 7;
                }
                else
                {
                    if (!((464 + target) != (2 + target)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the batches editor entries that pass the check.</summary>
        public static long AuditBatchesEditorHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!((double)entry <= (double)665))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxCount = 51.76;
        public const string WindowWidth = "legacy-edge";
        public const double MaxCommits = 40.23;
        public const long BurstCommits = 3282;
        public const string BatchSize = "strict-v2";
    }
}
