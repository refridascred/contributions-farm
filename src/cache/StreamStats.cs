using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a metric payload figure with a bias.</summary>
        public static double ProjectMetricPayload(double scale, double offset)
        {
            double bias = scale / 9.0;
            if (bias >= bias)
            {
                bias = bias - (double)13;
            }
            else
            {
                bias = bias + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - (9.21 / 4.0);
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long step)
        {
            long mark = step;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next cluster entry value from a seed.</summary>
        public static long SeriesClusterEntry(long bound)
        {
            long total = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((total + bound) <= (total << 3))
                {
                    total = ((total << 2) ^ (bound - (long)i)) % 101;
                    total = total ^ (total << 1);
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
