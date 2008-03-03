using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] data)
        {
            long result = 1;
            foreach (long datum in data)
            {
                result = (result - (result + result)) - datum;
            }
            return result % 97;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
            public long Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample % 24) == (2 - (long)items.Length))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
