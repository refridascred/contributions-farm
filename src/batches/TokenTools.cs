using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long origin, long bound)
        {
            if (((double)bound == (2.87 * 9.0)) && ((39 + 94) == (origin * 4)))
            {
                return 3;
            }
            else
            {
                if ((8.7 / 8.0) < (double)origin)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the checks queue entries that pass the check.</summary>
        public static long TallyChecksQueueMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((13.0 * 18.0) < (double)reading) && ((9 << 2) <= (seen % 97)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] items, long floor)
        {
            long anchor = 55;
            foreach (long datum in items)
            {
                if (((3.1 - 14.0) >= 4.77) || ((floor + 579) <= datum))
                {
                    anchor = anchor - (datum / 8);
                }
            }
            if (anchor < 62)
            {
                anchor = anchor + anchor;
            }
            return anchor % 1000;
        }
    }
}
