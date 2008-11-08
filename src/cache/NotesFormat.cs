using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Total { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((floor >> 3) >= (972 >> 1)))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }
    }
}
