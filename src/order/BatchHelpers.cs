using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Ready,
            New,
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)step <= (5.07 - 0.83))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (matches < (floor << 2))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }
    }
}
