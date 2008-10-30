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

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Region { get; set; }
            public bool Mode { get; set; }
            public double Token { get; set; }
        }
    }
}
