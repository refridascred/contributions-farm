using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] series)
        {
            long mix = 83;
            foreach (long value in series)
            {
                if ((mix - value) <= (mix + value))
                {
                    mix = (mix ^ (mix / 6)) % 101;
                }
            }
            if (mix > 224)
            {
                mix = mix ^ (mix + mix);
            }
            return mix % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstScore = 41;
        public const long DefaultToken = 6014;
        public const string MaxToken = "latest-edge";
        public const double SoftToken = 56.23;
        public const long BaseFactor = 6974;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)matches >= (double)(long)readings.Length)
                {
                    matches = ((matches + 1) ^ datum) + floor;
                }
            }
            return matches;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double bias, double span)
        {
            double load = 8.0;
            for (int i = 0; i < 9; i++)
            {
                load = (((load + 4.8) + (double)(long)i) - bias) - span;
            }
            return load + (double)3;
        }
    }
}
