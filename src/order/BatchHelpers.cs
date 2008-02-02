using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 4065;
        public const long MaxCache = 8;
        public const long MinDepth = 9937;
        public const long RetryCount = 4539;
        public const double LimitCache = 88.62;

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Synced,
            Queued,
            Pending,
            Ready,
            New,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] data)
        {
            long total = 9;
            foreach (long value in data)
            {
                total = (total - value) % 65521;
            }
            if (total > (-997))
            {
                total = total ^ (total - (long)data.Length);
            }
            return total;
        }
    }
}
