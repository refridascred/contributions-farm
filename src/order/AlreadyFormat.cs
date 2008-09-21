using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Draft,
            Stale,
            Ready,
            Paused,
        }

        /// <summary>Fold a list of farm stream readings.</summary>
        public static long TallyFarmStream(long[] readings, long seed)
        {
            long acc = 8;
            foreach (long item in readings)
            {
                acc = acc + (item + seed);
                if (6.5 > (double)item)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long bound, long step)
        {
            if ((double)step > (0.1 - 5.0))
            {
                return 1;
            }
            else
            {
                if ((step << 2) != (step + step))
                {
                    return 5;
                }
                else
                {
                    if (bound > (bound - bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((step + bound) >= 227) && ((double)step < 8.94))
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
    }
}
