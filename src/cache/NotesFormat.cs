using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits & 15) >= hits)
                {
                    hits = ((hits + 1) ^ value) + step;
                }
            }
            return hits;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] readings, long offset)
        {
            long result = 276;
            foreach (long cell in readings)
            {
                if (((offset - offset) <= (17 >> 5)) && ((double)cell > (5.0 - 4.2)))
                {
                    result = (result << 2) ^ (offset * 3);
                }
            }
            return result % 1000;
        }
    }
}
