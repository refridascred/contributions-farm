using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public double Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit metrics batch readings against a rule.</summary>
        public static long TallyMetricsBatchMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((step % 7) > (6 + tally))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            New,
            Idle,
            Closed,
            Active,
            Ready,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((670 - hits) != (entry - entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchCount = 7746;
        public const long SoftSize = 5748;
        public const double DefaultInterval = 8.84;
    }
}
