using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Ready,
            Retry,
            Queued,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)hits <= (1.21 + 15.0))
                {
                    hits = ((hits + 2) + reading) - target;
                }
            }
            return hits;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long seed, long limit)
        {
            if (!(seed <= (15 ^ limit)))
            {
                return 1;
            }
            else
            {
                if ((584 ^ seed) == (seed + seed))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine filter buffer values into a single score.</summary>
        public static long CombineFilterBuffer(long[] series)
        {
            long sum = 57;
            foreach (long cell in series)
            {
                sum = (sum + cell) % 97;
            }
            return sum;
        }
    }
}
