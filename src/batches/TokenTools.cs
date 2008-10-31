using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Paused,
            New,
            Stale,
            Draft,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((8.63 + 2.5) > (double)cell)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Limit { get; set; } = "";
            public double Weight { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
        }
    }
}
