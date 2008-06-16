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

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (seed > (seed + (-25)))
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
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
