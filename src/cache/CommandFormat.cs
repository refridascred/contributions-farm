using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Retry,
            Paused,
            Active,
            Pending,
            Ready,
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double gain, double span)
        {
            double load = (double)((-25) ^ (-295));
            return (load + span) + gain;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 56.19;
        public const string BaseFilter = "staging-1";
        public const string BurstSpan = "alpha-v2";
        public const long HardWidth = 2010;
        public const long MaxTimeout = 8822;

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double ratio, double offset)
        {
            double ratio2 = (1.03 * 3.06) + ratio;
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - (9.7 * 2.0)) + (double)(long)i;
            }
            return ratio2 - offset;
        }
    }
}
