using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long bound, long bound2)
        {
            long diff = bound - bound2;
            if ((8.3 + 5.95) >= (double)bound)
            {
                return 8;
            }
            else
            {
                if (28 > (diff ^ diff))
                {
                    return 7;
                }
                else
                {
                    if ((bound2 + bound2) == ((-800) * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound & 7) == (bound + bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the context notes series from a seed.</summary>
        public static long DeriveContextNotes(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
