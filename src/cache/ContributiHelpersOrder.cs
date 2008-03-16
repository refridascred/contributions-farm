using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((80 - entry) != ((long)data.Length << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] readings, long bound)
        {
            long carry = 0;
            foreach (long cell in readings)
            {
                carry = (carry + (carry & 3)) % 255;
                if ((bound - 18) == (carry << 2))
                {
                    carry = (carry - (long)readings.Length) % 101;
                }
                else
                {
                    carry = (carry - (cell >> 2)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((anchor > (5 / 5)) || ((0.7 + 7.14) >= (double)bound))
                {
                    anchor = anchor - ((-658) / 8);
                    anchor = (anchor + (925 + (long)i)) % 255;
                }
                else
                {
                    anchor = (anchor ^ (bound >> 3)) % 101;
                    anchor = anchor - 73;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
