using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate batch checks readings against a bound.</summary>
        public static bool GuardBatchChecksBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryRatio = 4395;
        public const long BaseDepth = 9108;
        public const double SoftRatio = 26.36;
        public const string MaxTimeout = "stable-1";
    }
}
