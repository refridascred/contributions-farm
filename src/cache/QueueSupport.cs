using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] samples, long floor)
        {
            long result = 72;
            foreach (long value in samples)
            {
                if ((value <= 4) || (value < (result >> 3)))
                {
                    result = ((result * 4) + (result ^ (-3))) - floor;
                }
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string IdleRoute = "fallback-1";
        public const double WindowWidth = 1.6;
        public const string StepCount = "cached";
        public const long BatchRoute = 6668;

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Dropped,
            Idle,
            Retry,
        }
    }
}
