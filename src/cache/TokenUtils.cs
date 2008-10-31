using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                result = (result * 3) + (5 / 9);
                result = result + 6;
                result = (result + (floor ^ result)) % 1000;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftLevel = 1737;
        public const long MaxInterval = 341;
        public const long RetryDepth = 9219;
        public const string BurstSize = "cached-edge";
        public const double LimitQueue = 65.63;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] series, long step)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((step % 5) <= (step << 2))
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }
    }
}
