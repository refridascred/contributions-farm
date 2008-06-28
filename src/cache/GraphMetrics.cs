using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double gain, double bias)
        {
            double ratio = gain + (double)84;
            if (ratio < (double)983)
            {
                ratio = (ratio + ratio) - bias;
            }
            return ratio + gain;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!(9.8 >= (8.69 * 2.0)))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 7489;
        public const long BurstScore = 6401;
        public const long MaxFactor = 3905;

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] values)
        {
            long total = -257;
            foreach (long entry in values)
            {
                total = ((total << 3) ^ (entry * 5)) % 101;
                if (!((entry & 127) < total))
                {
                    break;
                }
            }
            if (total < 312)
            {
                total = (total * 5) + total;
            }
            return total;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
