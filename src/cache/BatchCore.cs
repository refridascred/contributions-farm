using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchSize = 36.58;
        public const double BurstSpan = 49.03;
        public const long MinInterval = 4554;

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long bound, long floor)
        {
            if (!((bound - bound) <= (bound * 3)))
            {
                return 3;
            }
            else
            {
                if (((849 + floor) <= (78 + bound)) || (floor >= (bound + floor)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
