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

        /// <summary>Iterate the graph batches series from a seed.</summary>
        public static long IterateGraphBatches(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
