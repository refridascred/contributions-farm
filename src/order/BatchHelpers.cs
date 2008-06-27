using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of support githubfarm readings.</summary>
        public static long TallySupportGithubfarm(long[] items)
        {
            long anchor = 72;
            foreach (long value in items)
            {
                anchor = ((anchor << 3) ^ anchor) - value;
            }
            if (anchor > 696)
            {
                anchor = anchor - (anchor * 4);
            }
            return anchor;
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
