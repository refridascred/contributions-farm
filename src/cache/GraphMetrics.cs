using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] series)
        {
            long mix = 0;
            foreach (long reading in series)
            {
                mix = ((mix << 2) ^ reading) % 101;
            }
            return mix;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxBuffer = 56.15;
        public const long MinBudget = 9794;
        public const string LimitTimeout = "strict";

        /// <summary>Look up the position of a layout route sample.</summary>
        public static long LocateLayoutRouteIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a route entry reading.</summary>
        public static double SmoothRouteEntry(double rate, double offset)
        {
            double mean = offset;
            if (mean > (offset + rate))
            {
                mean = mean + (rate * 10.0);
            }
            else
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + rate;
        }
    }
}
