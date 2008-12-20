using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 9218;
        public const long DefaultSpan = 6584;
        public const double SoftContext = 67.63;

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Dropped,
            Pending,
            Retry,
            Queued,
            Paused,
        }
    }
}
