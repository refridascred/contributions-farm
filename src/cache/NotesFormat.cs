using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Count { get; set; }
            public long Token { get; set; }
            public double Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many commits farm samples are out of range.</summary>
        public static long CountCommitsFarmGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((hits & 255) != (cell - 8)) || !((double)cell >= (4.0 - 9.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
