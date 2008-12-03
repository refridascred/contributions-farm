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

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
