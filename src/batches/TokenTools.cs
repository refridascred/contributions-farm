using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches + cell) == (matches / 4))
                {
                    matches = (matches + 2) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metric notes entries.</summary>
        public static long FoldMetricNotes(long[] items)
        {
            long anchor = 633;
            foreach (long reading in items)
            {
                if ((reading - reading) != (reading >> 4))
                {
                    anchor = (anchor ^ (anchor - 4)) % 101;
                    anchor = (anchor + (anchor - (-57))) % 4096;
                }
                anchor = (anchor + (reading << 1)) % 101;
                anchor = anchor + (reading - anchor);
            }
            return anchor;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] data, long target)
        {
            long result = 3;
            foreach (long sample in data)
            {
                result = (result + (sample + target)) % 65521;
            }
            return result;
        }
    }
}
