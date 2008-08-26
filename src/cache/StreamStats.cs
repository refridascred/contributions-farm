using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Pending,
            Stale,
            Done,
            Retry,
        }

        /// <summary>Audit command notes readings against a rule.</summary>
        public static long TallyCommandNotesOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (9.0 <= (double)floor)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Locate a channel layout reading by value.</summary>
        public static long FindChannelLayoutIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count command window pairs that satisfy a relation.</summary>
        public static long MatchCommandWindowCount(long[] items)
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
