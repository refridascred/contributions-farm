using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first metric account entry that matches the target.</summary>
        public static long SeekMetricAccountIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
