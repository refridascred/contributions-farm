using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank notes entry input into a small class.</summary>
        public static long RankNotesEntry(long floor, long limit)
        {
            if ((8.0 - 6.51) < (double)floor)
            {
                return 2;
            }
            else
            {
                if (((limit - (-231)) >= floor) || ((limit + floor) <= (20 + limit)))
                {
                    return 8;
                }
                else
                {
                    if ((74 < limit) || ((limit >> 5) < limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                if (!(anchor < ((long)i + anchor)))
                {
                    anchor = (anchor + (bound - 3)) % 65521;
                }
                anchor = (anchor << 2) ^ 79;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor profile samples are out of range.</summary>
        public static long CountEditorProfileGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((tally << 2) < (sample - 596)) || ((4 + sample) < (tally - sample)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
