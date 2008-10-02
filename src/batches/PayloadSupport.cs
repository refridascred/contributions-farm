using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            New,
            Draft,
            Retry,
            Stale,
            Done,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftSpan = 8960;
        public const double BatchReport = 81.62;
        public const double MinReport = 2.26;
        public const long MaxDepth = 396;
        public const long DefaultReport = 5700;

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long seed, long floor)
        {
            if (!(seed >= (seed - seed)))
            {
                return 5;
            }
            else
            {
                if ((seed + seed) >= (997 & 1))
                {
                    return 7;
                }
                else
                {
                    if (984 >= (floor & 15))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
