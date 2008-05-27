using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Synced,
            Failed,
            New,
        }

        /// <summary>Look up the position of a stream account sample.</summary>
        public static long SeekStreamAccountIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 8195;
        public const string RetryScore = "staging-1";
        public const string HardInterval = "local";
        public const long HardFilter = 5244;
    }
}
