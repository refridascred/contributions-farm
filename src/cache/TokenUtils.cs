using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many notes account samples are out of range.</summary>
        public static long AuditNotesAccountHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading + seen) <= (seen >> 5))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Flag { get; set; }
            public bool Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 6156;
        public const long BaseTools = 7190;
        public const long DefaultSpan = 5363;
        public const string MaxTools = "latest";
    }
}
