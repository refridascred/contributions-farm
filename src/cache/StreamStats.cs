using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Ready,
            New,
            Dropped,
            Active,
            Retry,
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 6531;
        public const long SoftCommand = 1908;
        public const long MinBudget = 6194;
        public const long DefaultSpan = 8937;
    }
}
