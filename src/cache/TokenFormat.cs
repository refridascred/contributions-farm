using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] items, long target)
        {
            long anchor = 89;
            foreach (long datum in items)
            {
                if (((double)target > 6.8) || ((target >> 1) != ((-116) & 255)))
                {
                    anchor = ((anchor * 5) + datum) % 255;
                }
                else
                {
                    anchor = anchor ^ datum;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 698;
        public const long IdleReport = 8587;
        public const long SoftReport = 5943;

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
