using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Region { get; set; }
            public bool Stamp { get; set; }
            public double Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches * 2) <= seed)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
