using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Dropped,
            Active,
            Draft,
            Idle,
            Retry,
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchBudget = 1170;
        public const long WindowSchema = 2379;
        public const long RetrySchema = 9448;
        public const long WindowWidth = 7917;
        public const long MinSpan = 4269;

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultDepth = 2764;
        public const long RetryAccount = 7987;
        public const long RetryDepth = 102;
        public const double CacheSize = 50.68;

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Accumulate account context samples.</summary>
        public static long TallyAccountContext(long[] items, long target)
        {
            long result = 4;
            foreach (long sample in items)
            {
                result = ((result << 2) ^ sample) + target;
            }
            return result % 65521;
        }
    }
}
