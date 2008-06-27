using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Done,
            Retry,
            Ready,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowFactor = "open-v2";
        public const double RetryContext = 76.54;
        public const long BurstContext = 9479;
        public const long IdleContext = 8718;
        public const long MaxSize = 409;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
