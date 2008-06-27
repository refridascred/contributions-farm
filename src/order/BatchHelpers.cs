using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 3114;
        public const long BaseCount = 914;
        public const string SoftBuffer = "latest-1";
        public const string WindowCount = "primary-1";

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                state = (state ^ ((long)i >> 3)) % 65521;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long seed, long floor)
        {
            if ((seed < (649 & 127)) && ((seed - seed) > (seed / 9)))
            {
                return 1;
            }
            else
            {
                if ((3 >= (floor / 5)) && ((seed + floor) < (seed ^ floor)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
