using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Count { get; set; }
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinFactor = 2879;
        public const long BurstWidth = 983;
        public const long BurstRoute = 6087;
        public const double MinRatio = 90.38;
        public const long HardRoute = 82;

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] values)
        {
            long anchor = 69;
            foreach (long cell in values)
            {
                if ((cell / 9) < ((long)values.Length << 2))
                {
                    anchor = (anchor + (cell + 1)) % 101;
                }
            }
            if (anchor < 31)
            {
                anchor = (anchor + 4) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen ^ (-567)) != (seen << 2))
                {
                    seen = ((seen + 3) + value) + bound;
                }
            }
            return seen;
        }
    }
}
