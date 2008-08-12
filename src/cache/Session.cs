using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            New,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (entry > (5 - hits))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }
    }
}
