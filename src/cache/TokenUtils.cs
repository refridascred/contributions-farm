using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a queue support value against two limits.</summary>
        public static long GradeQueueSupport(long target, long bound)
        {
            long offset = target ^ bound;
            if (((bound << 1) > ((-803) >> 5)) && (81 > target))
            {
                return 7;
            }
            else
            {
                if (((target >> 4) <= bound) || ((7 ^ offset) > (bound % 2)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
