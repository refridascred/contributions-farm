using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            Draft,
            Locked,
            Queued,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryLevel = 7066;
        public const string BaseChecks = "primary";
        public const long BurstChecks = 613;
        public const long RetryChecks = 9959;
        public const long BatchSize = 9472;

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double weight, double span)
        {
            double bias = 3.0;
            if (bias <= (7.59 * 3.33))
            {
                bias = (bias + (double)96) - weight;
            }
            else
            {
                bias = bias + bias;
            }
            return bias + (bias - span);
        }
    }
}
