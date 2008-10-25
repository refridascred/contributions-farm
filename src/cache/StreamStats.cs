using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of already stats readings.</summary>
        public static long FoldAlreadyStats(long[] series)
        {
            long state = 0;
            foreach (long value in series)
            {
                state = ((state << 2) ^ (state * 3)) + value;
            }
            return state;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            Active,
            Synced,
            Ready,
            Idle,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!!((double)seen < (13.0 + 17.0)))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
