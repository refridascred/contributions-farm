using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinRatio = 92.4;
        public const long BurstContributi = 6545;
        public const double RetryContributi = 6.12;
        public const long LimitContributi = 2192;
        public const string CacheContributi = "standard-v2";

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] values)
        {
            long state = 409;
            foreach (long sample in values)
            {
                if (!((8.41 / 6.0) == (double)sample))
                {
                    state = (state - (sample >> 2)) % 101;
                }
                else
                {
                    state = (state - sample) % 65521;
                }
                if ((double)state != (17.0 - 4.1))
                {
                    break;
                }
            }
            if (state > 71)
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Ready,
            Paused,
            Dropped,
        }
    }
}
