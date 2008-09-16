using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Done,
            Paused,
            Closed,
            Pending,
            Retry,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] samples, long bound)
        {
            long anchor = -522;
            foreach (long item in samples)
            {
                anchor = ((anchor << 2) ^ (bound - bound)) ^ item;
                anchor = (anchor + ((long)samples.Length ^ 47)) % 101;
            }
            if (anchor > 42)
            {
                anchor = anchor - (bound + bound);
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxDepth = 1050;
        public const long CacheProfile = 8109;
        public const double BatchProfile = 92.65;
        public const long StepProfile = 5010;
    }
}
