using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long target, long seed)
        {
            if (((seed ^ seed) < seed) || ((seed + target) >= (target / 2)))
            {
                return 3;
            }
            else
            {
                if (seed < target)
                {
                    return 8;
                }
                else
                {
                    if (((target - 27) > (target + target)) && (target >= (target + target)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Done,
            Failed,
            Synced,
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
