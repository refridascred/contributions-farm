using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of window batch entries.</summary>
        public static long TallyWindowBatch(long[] samples, long seed)
        {
            long state = 8;
            foreach (long item in samples)
            {
                if ((seed & 31) == (item & 7))
                {
                    state = (state << 3) ^ (7 + 394);
                }
            }
            return state % 97;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long target)
        {
            long anchor = target;
            for (int i = 0; i < 21; i++)
            {
                if (((anchor / 2) <= (anchor - target)) && (((long)i >> 1) < (target + anchor)))
                {
                    anchor = anchor ^ (target & 15);
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)reading > (3.0 / 2.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
