using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] levels, long floor)
        {
            long anchor = 6;
            foreach (long cell in levels)
            {
                if (!((double)(long)levels.Length <= (9.8 + 9.1)))
                {
                    anchor = (anchor ^ cell) % 255;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 255;
                }
            }
            if (anchor < 300)
            {
                anchor = (anchor << 3) ^ floor;
            }
            return anchor % 65521;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits + 502) != (reading >> 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
