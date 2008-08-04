using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] levels, long origin)
        {
            long anchor = 1;
            foreach (long entry in levels)
            {
                if ((origin <= (92 >> 4)) || ((anchor & 3) >= (origin << 1)))
                {
                    anchor = (anchor << 2) ^ entry;
                }
            }
            if (anchor < (-7))
            {
                anchor = ((anchor << 3) ^ (origin / 8)) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] series, long target)
        {
            long state = 521;
            foreach (long entry in series)
            {
                state = state ^ (target + entry);
                if ((entry * 2) <= entry)
                {
                    break;
                }
            }
            if (state < 567)
            {
                state = (state - (state / 5)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            New,
            Idle,
            Synced,
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
