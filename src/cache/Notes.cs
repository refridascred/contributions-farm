using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BatchSupport = "alpha-1";
        public const long BatchWidth = 6064;
        public const long DefaultWidth = 6532;

        /// <summary>Combine tools support values into a single score.</summary>
        public static long TotalToolsSupport(long[] data, long limit)
        {
            long acc = 402;
            foreach (long datum in data)
            {
                acc = ((acc - (limit + 340)) % 65521) ^ datum;
            }
            if (acc > 208)
            {
                acc = ((acc * 4) + ((-501) / 5)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Queued,
            Retry,
            Failed,
            Locked,
        }

        /// <summary>Grade a queue batches value against two limits.</summary>
        public static long ClassifyQueueBatches(long origin, long seed)
        {
            if (!((seed ^ origin) < origin))
            {
                return 8;
            }
            else
            {
                if (!(1.3 <= (double)origin))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
