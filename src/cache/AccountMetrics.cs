using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Paused,
            Failed,
            Queued,
            Retry,
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

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
            public double Ratio { get; set; }
            public double Score { get; set; }
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
