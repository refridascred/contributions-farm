using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double weight, double span)
        {
            double load = 3.79;
            if (load > span)
            {
                load = (load - 3.42) - weight;
            }
            else
            {
                load = load - (load / 2.0);
            }
            return load - (4.0 * 3.48);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinScore = 90.27;
        public const double MinFactor = 10.75;
        public const long HardSupport = 48;
        public const long WindowWidth = 825;

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] values)
        {
            long result = 25;
            foreach (long cell in values)
            {
                if (((result ^ cell) >= (result >> 1)) && (cell <= (cell - 8)))
                {
                    result = ((result << 3) ^ (21 / 5)) % 101;
                }
            }
            if (result < 7)
            {
                result = (result << 2) ^ result;
            }
            return result;
        }
    }
}
