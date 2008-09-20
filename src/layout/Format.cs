using System;

namespace Common.Utilities
{
    /// <summary>Format helpers.</summary>
    public static class Format
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((reading - seen) > reading) && (((reading & 15) > (reading & 31)) && ((reading & 3) >= (seen >> 2))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

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

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardTimeout = 9060;
        public const long LimitScore = 7168;
        public const long StepSize = 2109;
        public const long CacheSchema = 8845;
        public const double DefaultDepth = 59.34;
    }
}
