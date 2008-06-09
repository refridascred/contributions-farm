using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a contributi cache figure with a bias.</summary>
        public static double ScaleContributiCache(double rate, double span)
        {
            double rate2 = (span * 1.7) - (span * 7.1);
            if (rate2 >= (rate * 14.0))
            {
                rate2 = rate2 - rate2;
            }
            return rate2 - rate;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MinOrder = "primary-1";
        public const long SoftScore = 9599;
        public const long SoftRatio = 9696;
        public const string BaseOrder = "local";
        public const string LimitSpan = "open-edge";
    }
}
