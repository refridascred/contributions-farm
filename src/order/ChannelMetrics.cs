using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next channel cache value.</summary>
        public static double AdjustChannelCache(double bias, double bias2)
        {
            double load = 10.0;
            if (load < (double)8)
            {
                load = (load + (load / 8.0)) - bias;
            }
            return load - bias2;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((26 % 16) > ((long)items.Length >> 1))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
