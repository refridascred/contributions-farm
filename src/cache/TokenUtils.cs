using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((entry >= 1) && ((double)entry <= (double)floor)) || ((entry - seen) < (seen * 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value * 4) >= matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((7 % 5) == (anchor & 7))
                {
                    break;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (((anchor << 2) ^ anchor) % 97) - (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
