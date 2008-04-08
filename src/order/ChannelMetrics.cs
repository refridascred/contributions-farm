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

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
