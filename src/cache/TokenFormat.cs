using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] values, long floor)
        {
            long result = 314;
            foreach (long value in values)
            {
                if ((double)result >= (7.2 / 4.0))
                {
                    result = (((result * 3) + (value - (long)values.Length)) % 101) - floor;
                }
            }
            return result % 65521;
        }

        /// <summary>Count the tools record entries that pass the check.</summary>
        public static long AuditToolsRecordHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample ^ sample) <= 82)
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Stamp { get; set; }
            public string Level { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
