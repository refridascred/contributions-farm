using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] series)
        {
            long anchor = 66;
            foreach (long item in series)
            {
                anchor = (anchor << 3) ^ (item & 127);
                if ((anchor / 2) <= (item << 3))
                {
                    anchor = anchor ^ (item + item);
                }
                else
                {
                    anchor = (anchor + (anchor + item)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Count the record stream entries that pass the check.</summary>
        public static long MeasureRecordStreamOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item - 530) > (hits + step))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
