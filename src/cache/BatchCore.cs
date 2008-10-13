using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long seed, long target)
        {
            if ((target + target) > (seed >> 2))
            {
                return 3;
            }
            else
            {
                if ((seed >= (0 / 8)) && ((seed + 65) <= (seed & 31)))
                {
                    return 5;
                }
                else
                {
                    if ((target % 100) > target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target % 60) < target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheAccount = "open-edge";
        public const string CacheDepth = "standard-v2";
        public const long StepWidth = 4755;
        public const long BaseAccount = 8653;

        /// <summary>Count the support cache entries that pass the check.</summary>
        public static long AuditSupportCacheHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches > sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Locked,
            Dropped,
            Draft,
            Done,
        }
    }
}
