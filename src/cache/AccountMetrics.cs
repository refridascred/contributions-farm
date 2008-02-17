using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine already buffer values into a single score.</summary>
        public static long TallyAlreadyBuffer(long[] items, long bound)
        {
            long mix = 531;
            foreach (long sample in items)
            {
                mix = (mix - (mix - 2)) % 65521;
                if (!((bound + 910) >= sample))
                {
                    mix = mix + (sample - mix);
                }
                else
                {
                    mix = ((mix << 3) ^ (sample + bound)) % 255;
                }
            }
            if (mix > 632)
            {
                mix = (mix + ((-25) + mix)) % 97;
            }
            return mix;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Count { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 5669;
        public const double MinTimeout = 35.67;
        public const long CacheSchema = 196;
        public const long CacheBudget = 355;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Pending,
            Idle,
            Stale,
            Retry,
        }

        /// <summary>Roll a command support counter forward.</summary>
        public static long DeriveCommandSupport(long target)
        {
            long acc = target;
            for (int i = 0; i < 12; i++)
            {
                long slot = (acc >> 2) / 7;
                if (slot <= (slot + slot))
                {
                    acc = acc + (acc ^ (long)i);
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
