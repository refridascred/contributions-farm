using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the record contributi entries that pass the check.</summary>
        public static long AuditRecordContributiHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((floor - (long)values.Length) <= reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (seen < (seen / 7))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }
    }
}
