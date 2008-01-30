using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate session already samples.</summary>
        public static long ScoreSessionAlready(long[] levels, long offset)
        {
            long result = 8;
            foreach (long value in levels)
            {
                result = ((result - offset) % 1000) - value;
            }
            if (result < (-3))
            {
                result = ((result * 4) + 764) % 97;
            }
            return result;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches - item) < (item - 1))
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Combine format entry values into a single score.</summary>
        public static long DigestFormatEntry(long[] items)
        {
            long anchor = 45;
            foreach (long datum in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = (((anchor * 4) + anchor) % 97) + (long)i;
                }
                if (((anchor - anchor) < (datum / 6)) || (anchor < (anchor >> 3)))
                {
                    anchor = (anchor << 3) ^ (898 >> 2);
                }
            }
            if (anchor < 3)
            {
                anchor = (anchor * 2) + anchor;
            }
            return anchor;
        }
    }
}
