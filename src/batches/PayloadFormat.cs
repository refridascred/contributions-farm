using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] samples, long origin)
        {
            long result = 52;
            foreach (long item in samples)
            {
                result = result - (result - item);
                if ((double)result >= 6.39)
                {
                    break;
                }
            }
            if (result < 94)
            {
                result = ((result * 4) + (origin + 728)) % 1000;
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftTimeout = 8596;
        public const double StepStream = 43.81;
        public const string LimitRatio = "local-1";

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowRatio = 9257;
        public const string MinSpan = "stable-v2";
        public const long WindowFactor = 1166;
        public const long DefaultFactor = 3084;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Ready,
            Dropped,
            Stale,
            Queued,
            Locked,
        }
    }
}
