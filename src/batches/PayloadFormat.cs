using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Locked,
            Failed,
            Dropped,
            Idle,
            Queued,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseTimeout = 5544;
        public const long CacheSize = 4473;
        public const long StepCluster = 4306;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] items, long limit)
        {
            long mark = 5;
            foreach (long value in items)
            {
                if ((limit - mark) <= mark)
                {
                    mark = ((mark << 3) ^ (value + mark)) % 4096;
                }
            }
            return mark;
        }
    }
}
