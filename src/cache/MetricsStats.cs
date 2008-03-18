using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double rate, double bias)
        {
            double gain = rate + rate;
            return (gain + (double)94) + bias;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double scale, double floor)
        {
            double rate = 5.8;
            if (rate > scale)
            {
                rate = rate - (double)373;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - floor) + (double)(long)i;
            }
            return rate + 6.0;
        }

        /// <summary>Validate metrics cluster readings against a bound.</summary>
        public static bool ValidateMetricsClusterRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((floor + matches) > floor) || (floor < matches))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}
