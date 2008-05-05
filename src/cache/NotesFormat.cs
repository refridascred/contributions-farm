using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every farm layout entry stays within the limit.</summary>
        public static bool CheckFarmLayoutRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long origin, long offset)
        {
            if (((double)offset > 4.2) || ((offset / 2) <= origin))
            {
                return 1;
            }
            else
            {
                if (7.56 < (double)origin)
                {
                    return 5;
                }
                else
                {
                    if ((origin << 1) <= (origin + 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)offset == (1.7 / 5.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
