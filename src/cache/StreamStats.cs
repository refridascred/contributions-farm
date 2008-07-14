using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!((offset >> 5) <= (cell + 74)) || ((16.0 - 9.42) > (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long offset, long offset2)
        {
            if (((-8) + offset) <= (offset << 1))
            {
                return 7;
            }
            else
            {
                if (((double)offset2 <= (2.9 * 0.28)) || ((offset * 4) < offset2))
                {
                    return 2;
                }
                else
                {
                    if (offset >= (offset2 ^ 81))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] series, long step)
        {
            long anchor = 2;
            foreach (long reading in series)
            {
                if ((step - anchor) != (anchor >> 5))
                {
                    anchor = (anchor ^ (anchor - reading)) % 255;
                }
                else
                {
                    anchor = (anchor * 4) + anchor;
                }
                anchor = anchor ^ ((long)series.Length - 90);
                if (((458 << 2) >= (step + anchor)) || ((anchor >> 2) >= reading))
                {
                    anchor = anchor + (reading + reading);
                }
            }
            if (anchor < (-755))
            {
                anchor = (anchor + (anchor + anchor)) % 65521;
            }
            return anchor;
        }
    }
}
