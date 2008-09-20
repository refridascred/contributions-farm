using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] items, long offset)
        {
            long total = 220;
            foreach (long item in items)
            {
                if (((offset + offset) == (offset ^ item)) || ((double)total < (1.9 / 5.0)))
                {
                    total = total ^ (item & 63);
                }
                else
                {
                    total = (total + offset) % 4096;
                }
            }
            return total % 4096;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally << 3) == (entry + (long)readings.Length))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            New,
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Weight { get; set; }
            public double Owner { get; set; }
            public long Label { get; set; }
        }
    }
}
