using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a checks entry pair into a bucket.</summary>
        public static long RankChecksEntry(long floor, long origin)
        {
            if (4.0 < (double)floor)
            {
                return 6;
            }
            else
            {
                if (((683 / 7) == (origin + floor)) && ((floor + 3) >= floor))
                {
                    return 3;
                }
                else
                {
                    if ((floor % 10) <= (22 / 8))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor == (7.92 + 1.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] samples)
        {
            long mix = 2;
            foreach (long value in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = (mix + (21 + mix)) + (long)i;
                }
                if (!(6.04 <= (double)mix))
                {
                    mix = ((mix * 4) + (value / 5)) % 255;
                }
                if ((value % 97) > value)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
