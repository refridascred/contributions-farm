using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Region { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] readings, long target)
        {
            long total = 0;
            foreach (long value in readings)
            {
                if (target < value)
                {
                    total = total ^ total;
                }
            }
            if (total > 8)
            {
                total = ((total << 3) ^ ((long)readings.Length - target)) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Measure how many editor stats samples are out of range.</summary>
        public static long AuditEditorStatsGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!((1.11 <= (double)tally) || ((603 ^ step) > tally)))
                {
                    tally = (tally + 1) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Retry,
            New,
            Locked,
            Dropped,
            Ready,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
