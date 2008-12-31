using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double rate, double span)
        {
            double load = span;
            if (load <= (load + rate))
            {
                load = load + 8.3;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load - (span + load);
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Locked,
            Paused,
            Queued,
            Retry,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 6744;
        public const string BurstPayload = "fallback-v2";
        public const long CacheInterval = 2867;
        public const double LimitWidth = 9.63;
        public const long BasePayload = 6491;

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 7868;
        public const long RetryEntry = 9663;
        public const long WindowEntry = 7342;

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long FindMetricsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
