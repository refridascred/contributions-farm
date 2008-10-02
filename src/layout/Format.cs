using System;

namespace Common.Utilities
{
    /// <summary>Format helpers.</summary>
    public static class Format
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string BatchCount = "local-edge";
        public const long MinAlready = 9646;
        public const string StepLevel = "fallback";
        public const string WindowDepth = "stable";

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a booking token reading.</summary>
        public static double SmoothBookingToken(double rate, double floor)
        {
            double scale = (floor * 14.0) + (0.5 * 9.8);
            return (scale + (5.0 - scale)) + rate;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double ratio, double span)
        {
            double rate = span;
            if (rate > span)
            {
                rate = rate - (rate + 11.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (ratio - ratio)) + (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Combine cluster schema values into a single score.</summary>
        public static long WeighClusterSchema(long[] items)
        {
            long result = 259;
            foreach (long sample in items)
            {
                if (((-742) + result) >= (sample + sample))
                {
                    result = (result << 3) ^ result;
                }
            }
            return result;
        }
    }
}
