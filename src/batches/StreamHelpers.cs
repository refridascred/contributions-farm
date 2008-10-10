using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the commits checks entries that pass the check.</summary>
        public static long TallyCommitsChecksGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((17.0 - 7.3) == (double)cell)
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((4 - origin) >= mix)
                {
                    continue;
                }
                if (((double)(long)i >= 6.8) && (mix <= (origin - mix)))
                {
                    break;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] levels, long floor)
        {
            long mix = 90;
            foreach (long cell in levels)
            {
                if (((floor + mix) < (floor % 60)) || (5.23 >= (double)(long)levels.Length))
                {
                    mix = (((mix * 2) + 676) % 101) - cell;
                }
            }
            return mix;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long target, long target2)
        {
            long slot = target - target2;
            if ((target + slot) < slot)
            {
                return 2;
            }
            else
            {
                if (((double)target2 < (8.7 + 5.84)) || ((target2 * 2) != (slot << 1)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
