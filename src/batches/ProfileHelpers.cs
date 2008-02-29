using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Label { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 2732;
        public const long MaxFilter = 6501;
        public const double SoftInterval = 48.7;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long floor, long floor2)
        {
            long offset = floor ^ floor2;
            if ((offset ^ floor) < offset)
            {
                return 1;
            }
            else
            {
                if ((offset - 4) >= (offset - floor))
                {
                    return 5;
                }
                else
                {
                    if (!((floor2 % 7) > (782 << 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset - floor2) > ((-1) + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
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
