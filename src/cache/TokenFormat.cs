using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc * 2) + (acc << 2);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
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
