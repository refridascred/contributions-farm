using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)hits < (double)limit)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] data)
        {
            long state = -693;
            foreach (long entry in data)
            {
                if ((state + entry) < (81 * 5))
                {
                    state = (state + state) % 97;
                }
            }
            return state;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
