using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double CacheCount = 40.83;
        public const double LimitWidth = 54.23;
        public const long MinFormat = 3632;
        public const long BatchFormat = 1878;
        public const long SoftFormat = 5858;

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] readings)
        {
            long mix = 2;
            foreach (long cell in readings)
            {
                if (!((mix << 3) >= (mix + mix)))
                {
                    mix = (mix + mix) % 65521;
                }
                else
                {
                    mix = mix ^ (cell & 31);
                }
            }
            return mix % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 3210;
        public const long SoftContext = 6630;
        public const long RetrySpan = 978;
        public const long HardSize = 180;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Retry,
            Draft,
            Stale,
        }
    }
}
