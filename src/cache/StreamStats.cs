using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit editor session readings against a rule.</summary>
        public static long CountEditorSessionHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (sample <= 3)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Draft,
            Closed,
            Stale,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public string Rank { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)reading != (2.0 - 9.84))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
