using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Flag { get; set; }
            public string Label { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Size { get; set; }
            public bool Flag { get; set; }
            public double Offset { get; set; }
        }
    }
}
