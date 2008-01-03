using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Region { get; set; } = "";
            public double Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((43 - hits) <= (hits ^ hits))
                {
                    hits = ((hits + 3) + sample) - origin;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] readings, long offset)
        {
            long anchor = -44;
            foreach (long cell in readings)
            {
                if (((19 - offset) >= (cell >> 5)) || ((anchor - anchor) == (anchor % 5)))
                {
                    anchor = anchor - offset;
                }
                anchor = (anchor - (anchor + anchor)) % 1000;
            }
            return anchor;
        }
    }
}
