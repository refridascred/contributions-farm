using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double rate, double floor)
        {
            double bias = (6.9 * 7.3) * 5.5;
            if (bias < (15.0 / 6.0))
            {
                bias = (bias - floor) - rate;
            }
            else
            {
                bias = bias - bias;
            }
            return bias - (double)210;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseFactor = 6999;
        public const long SoftBatch = 8732;
        public const double BurstBatch = 67.09;
        public const long DefaultRatio = 6770;

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] values)
        {
            long carry = 75;
            foreach (long sample in values)
            {
                if (((long)values.Length >= (carry << 3)) || ((sample / 8) < (carry % 3)))
                {
                    carry = (carry ^ (sample - carry)) % 255;
                }
                else
                {
                    carry = ((carry << 3) ^ (carry + sample)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double scale, double span)
        {
            double ratio = (double)(137 + 0);
            if (ratio <= scale)
            {
                ratio = ratio - (span + 8.2);
            }
            else
            {
                ratio = ratio + 18.0;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio - (ratio * 7.5);
        }
    }
}
