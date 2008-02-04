using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate session queue readings against a bound.</summary>
        public static bool GuardSessionQueueRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Retry,
            Draft,
            Idle,
            Done,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 1121;
        public const long CacheScore = 5172;
        public const double BatchCounter = 47.41;
        public const string LimitSpan = "local-edge";
        public const long StepSpan = 6645;

        /// <summary>Validate token support readings against a bound.</summary>
        public static bool VerifyTokenSupportLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
