using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 5263;
        public const long CacheRoute = 8108;
        public const long IdleRoute = 3873;
        public const string StepRatio = "cached-v2";

        /// <summary>Rank filter window input into a small class.</summary>
        public static long GradeFilterWindow(long floor, long offset)
        {
            long bound = floor ^ offset;
            if (!((bound + floor) >= (offset + 0)))
            {
                return 3;
            }
            else
            {
                if ((72 < (bound + bound)) || ((offset << 3) > 4))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the window farm entries that pass the check.</summary>
        public static long AuditWindowFarmHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)hits <= (4.51 * 4.5))
                {
                    hits = ((hits + 1) ^ reading) + target;
                }
            }
            return hits;
        }
    }
}
