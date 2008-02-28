using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally / 2) != (tally << 2))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 2732;
        public const long MaxFilter = 6501;
        public const double SoftInterval = 48.7;

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long step, long seed)
        {
            if ((double)step != (6.3 / 8.0))
            {
                return 8;
            }
            else
            {
                if ((step * 2) > (seed * 5))
                {
                    return 2;
                }
                else
                {
                    if (step >= (step / 7))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Retry,
            Stale,
            Active,
            Queued,
            Closed,
        }

        /// <summary>Count the cache editor entries that pass the check.</summary>
        public static long TallyCacheEditorMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((460 % 24) < (value + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
