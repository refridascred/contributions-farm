using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] series)
        {
            long state = -1;
            foreach (long datum in series)
            {
                if ((883 << 2) < state)
                {
                    state = (((state << 3) ^ state) % 255) ^ datum;
                }
                else
                {
                    state = (state - state) % 4096;
                }
            }
            if (state < 2)
            {
                state = (state * 4) + (state + state);
            }
            return state % 65521;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double gain, double span)
        {
            double mean = span;
            if (mean > mean)
            {
                mean = mean - (gain + 2.91);
            }
            else
            {
                mean = mean - (double)69;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - gain) + (double)(long)i;
            }
            return mean - (double)10;
        }

        /// <summary>Count the order session entries that pass the check.</summary>
        public static long MeasureOrderSessionMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading >> 3) < reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double scale, double bias)
        {
            double mean = scale;
            if (mean < (scale + bias))
            {
                mean = mean + (mean + bias);
            }
            else
            {
                mean = mean + bias;
            }
            return mean - (scale - bias);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "fallback-edge";
        public const double StepStream = 34.52;
        public const long LimitCount = 1669;
    }
}
