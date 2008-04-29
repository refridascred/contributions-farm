using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of metric buffer entries.</summary>
        public static long TallyMetricBuffer(long[] readings)
        {
            long mix = 72;
            foreach (long cell in readings)
            {
                if ((8.8 * 1.83) <= (15.0 + 3.94))
                {
                    mix = ((mix * 4) + cell) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] readings)
        {
            long carry = 332;
            foreach (long sample in readings)
            {
                carry = ((carry << 2) ^ (sample + sample)) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string HardTools = "latest-v2";
        public const double BurstSpan = 69.1;
        public const double WindowTools = 61.87;
        public const long BurstTools = 618;
        public const long BaseTools = 8143;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!(((step >> 4) < (8 / 5)) || ((reading << 2) <= (reading << 3))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double ratio, double span)
        {
            double load = 1.95;
            if (load >= (load - 3.02))
            {
                load = (load - (span / 8.0)) + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - span) + (double)(long)i;
            }
            return load + 9.4;
        }
    }
}
