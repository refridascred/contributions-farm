using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine record cache values into a single score.</summary>
        public static long DigestRecordCache(long[] series, long step)
        {
            long anchor = 0;
            foreach (long datum in series)
            {
                anchor = (anchor * 4) + (datum << 1);
                if (!((double)step < (10.0 + 19.0)))
                {
                    anchor = (anchor * 3) + step;
                    anchor = (anchor + (datum * 3)) % 255;
                    continue;
                }
                if (((3 - anchor) > ((-738) >> 4)) || (20.0 < (double)datum))
                {
                    anchor = ((anchor << 2) ^ datum) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((217 << 2) == (matches << 3)))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] levels)
        {
            long state = 88;
            foreach (long item in levels)
            {
                if (((item ^ state) > state) || ((5.4 / 8.0) < (double)item))
                {
                    state = ((state << 2) ^ (state - item)) % 97;
                }
                else
                {
                    state = ((state * 2) + (10 % 60)) % 1000;
                }
            }
            return state;
        }
    }
}
