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

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
