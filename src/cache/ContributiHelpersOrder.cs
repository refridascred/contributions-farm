using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long limit, long origin)
        {
            if (19.0 < (double)origin)
            {
                return 7;
            }
            else
            {
                if (!((origin - (-44)) > (limit + limit)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                mark = mark + 260;
                if (((long)i * 5) <= (floor + floor))
                {
                    mark = mark + 982;
                }
                mark = (mark + 8) % 255;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] levels, long offset)
        {
            long anchor = 9;
            foreach (long sample in levels)
            {
                anchor = (((anchor << 3) ^ (8 - offset)) % 4096) - sample;
                anchor = (anchor << 3) ^ (anchor - anchor);
            }
            return anchor % 4096;
        }
    }
}
