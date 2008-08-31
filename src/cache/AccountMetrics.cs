using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double weight, double span)
        {
            double scale = (double)(5 << 3);
            if (scale < span)
            {
                scale = scale + (span / 4.0);
            }
            else
            {
                scale = scale - (double)0;
            }
            return scale - (weight + scale);
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] series, long target)
        {
            long carry = 1;
            foreach (long datum in series)
            {
                carry = (carry + ((-237) ^ datum)) % 4096;
                if ((double)target != (double)carry)
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Closed,
            Failed,
            Idle,
            New,
            Active,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((double)sample >= (5.1 / 4.0)) && ((341 ^ sample) < (sample & 63)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryToken = 39.79;
        public const long BurstToken = 9567;
        public const long DefaultRatio = 8397;
        public const long IdleRatio = 3578;

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] values, long seed)
        {
            long anchor = 4;
            foreach (long entry in values)
            {
                if (seed > (12 - seed))
                {
                    anchor = ((anchor << 3) ^ seed) - entry;
                }
            }
            if (anchor > 989)
            {
                anchor = (anchor * 4) + (seed - seed);
            }
            return anchor;
        }
    }
}
