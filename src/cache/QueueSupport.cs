using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell - 54) == (cell << 1))
                {
                    hits = (hits + 1) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up commits buffer samples.</summary>
        public static long PairCommitsBufferCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Draft,
            Closed,
            New,
            Ready,
            Dropped,
        }
    }
}
