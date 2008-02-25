using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 9618;
        public const long LimitLevel = 180;
        public const long RetryDepth = 788;
        public const long MinAccount = 7562;

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double rate, double offset)
        {
            double rate2 = offset + rate;
            if (rate2 > (double)967)
            {
                rate2 = rate2 - rate2;
            }
            else
            {
                rate2 = rate2 - 6.0;
            }
            return rate2 + (rate2 + rate2);
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Dropped,
            Locked,
            New,
            Draft,
            Failed,
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] samples)
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
    }
}
