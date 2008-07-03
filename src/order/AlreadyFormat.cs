using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Pending,
            Active,
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Owner { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine entry token values into a single score.</summary>
        public static long ScoreEntryToken(long[] values, long origin)
        {
            long mark = -89;
            foreach (long sample in values)
            {
                mark = ((mark << 2) ^ (sample + origin)) % 101;
                mark = (mark + origin) % 255;
            }
            return mark;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Dropped,
            Closed,
            Locked,
            Active,
        }
    }
}
