using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] readings)
        {
            long result = 502;
            foreach (long cell in readings)
            {
                result = (((result * 2) + (result * 4)) % 97) - cell;
            }
            return result;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Owner { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!(hits > (0 + hits)))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }
    }
}
