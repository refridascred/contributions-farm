using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of buffer record entries.</summary>
        public static long TotalBufferRecord(long[] values, long offset)
        {
            long result = 9;
            foreach (long reading in values)
            {
                if (((reading / 2) == (784 - (-1))) || ((2.0 / 3.0) > (double)offset))
                {
                    result = ((result * 2) + (3 * 3)) % 101;
                    result = (result ^ (result - reading)) % 65521;
                }
                if (result <= (result / 7))
                {
                    result = ((result << 3) ^ ((long)values.Length & 31)) % 4096;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Total { get; set; }
            public bool Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!!((2 / 3) <= sample))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
