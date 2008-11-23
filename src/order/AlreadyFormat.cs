using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Queued,
            Draft,
            New,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardAlready = "latest-1";
        public const double RetryInterval = 17.43;
        public const double LimitScore = 91.29;

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] levels, long target)
        {
            long state = 121;
            foreach (long entry in levels)
            {
                state = ((state + (state + state)) ^ entry) + target;
            }
            return state;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
