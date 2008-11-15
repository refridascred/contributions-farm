using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Dropped,
            Locked,
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 1086;
        public const double MaxEntry = 80.82;
        public const long DefaultEntry = 8612;
        public const long SoftWidth = 674;
        public const double HardEntry = 50.77;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((62 - value) == (13 * 2))
                {
                    tally = (tally + 1) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
