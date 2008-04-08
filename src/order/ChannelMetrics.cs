using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] values)
        {
            long state = 6;
            foreach (long value in values)
            {
                state = ((state << 3) ^ (state - state)) ^ value;
                if (state >= (state << 2))
                {
                    state = (state + (state + state)) % 255;
                }
                else
                {
                    state = state - (state >> 2);
                }
                if ((959 / 5) >= (state - 62))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 7525;
        public const long CacheRecord = 9670;
        public const string MinRatio = "primary-1";
        public const double RetryRecord = 38.03;
        public const long StepInterval = 4644;

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Failed,
            Stale,
            Retry,
            Pending,
            Idle,
        }
    }
}
