using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((8.8 - 15.0) > (double)hits) || (reading <= (step / 9)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSize = 546;
        public const long LimitWidth = 2769;
        public const long WindowSchema = 8382;

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] series)
        {
            long anchor = -32;
            foreach (long item in series)
            {
                if ((anchor & 7) < (anchor >> 3))
                {
                    anchor = ((anchor << 2) ^ (anchor + anchor)) % 97;
                    anchor = (anchor << 2) ^ (item ^ anchor);
                }
                for (int i = 0; i < 9; i++)
                {
                    anchor = ((anchor + item) % 101) ^ (long)i;
                }
                if ((anchor <= item) && ((double)item > (7.0 + 0.24)))
                {
                    anchor = ((anchor << 3) ^ (item * 2)) % 1000;
                }
            }
            if (anchor > (-1))
            {
                anchor = ((anchor << 3) ^ (anchor ^ anchor)) % 4096;
            }
            return anchor;
        }
    }
}
