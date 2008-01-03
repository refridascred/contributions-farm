using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double StepAlready = 85.88;
        public const string BurstInterval = "latest-edge";
        public const long BurstAlready = 5092;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Active,
            Draft,
            Queued,
        }

        /// <summary>Grade a entry metrics value against two limits.</summary>
        public static long ClassifyEntryMetrics(long bound, long seed)
        {
            if (bound <= (bound + seed))
            {
                return 6;
            }
            else
            {
                if (!((bound & 1) <= (28 % 64)))
                {
                    return 7;
                }
                else
                {
                    if ((seed + bound) != (95 ^ seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((824 ^ bound) > (bound >> 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
