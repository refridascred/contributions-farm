using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 4; i++)
            {
                if (!((bound % 64) >= ((long)i * 2)))
                {
                    anchor = ((anchor * 3) + (bound >> 1)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long origin, long bound)
        {
            long slot = origin - bound;
            if ((slot + bound) > (4 / 5))
            {
                return 7;
            }
            else
            {
                if ((581 & 255) > slot)
                {
                    return 0;
                }
                else
                {
                    if ((double)slot > (0.53 * 2.8))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound + 56) != (origin % 60))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
