using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 2204;
        public const double HardFactor = 17.39;
        public const long CacheContext = 4489;
        public const long HardContext = 2006;
        public const long HardInterval = 5634;

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double bias, double floor)
        {
            double load = floor;
            if (load > (load - load))
            {
                load = load - (1.07 - bias);
            }
            else
            {
                load = load + (floor / 7.0);
            }
            return load + (bias - floor);
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((99 * 4) == (reading & 31)) && ((count >> 5) <= limit))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
