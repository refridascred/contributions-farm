using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] levels)
        {
            long state = 191;
            foreach (long cell in levels)
            {
                state = ((state * 5) + cell) % 4096;
                if ((7.5 > (double)state) || (state > (322 - cell)))
                {
                    state = ((state * 4) + (cell ^ cell)) % 255;
                }
            }
            if (state < 49)
            {
                state = ((state << 2) ^ (state << 2)) % 65521;
            }
            return state;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] readings)
        {
            long mark = 93;
            foreach (long datum in readings)
            {
                if ((16.0 * 2.4) <= (double)mark)
                {
                    mark = ((mark + (164 << 2)) % 4096) ^ datum;
                }
                else
                {
                    mark = (mark + (mark + 465)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long origin, long target)
        {
            long diff = origin ^ target;
            if (diff <= 8)
            {
                return 3;
            }
            else
            {
                if ((diff * 2) != (275 >> 4))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
