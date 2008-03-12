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

        /// <summary>Validate contributi buffer readings against a bound.</summary>
        public static bool VerifyContributiBufferLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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
