using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Locked,
            Active,
            Queued,
            Synced,
            New,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 4235;
        public const string IdleChannel = "fallback-edge";
        public const double BurstChannel = 77.35;
        public const long LimitLevel = 6831;
        public const long WindowChannel = 1747;

        /// <summary>Audit entry layout readings against a rule.</summary>
        public static long AuditEntryLayoutMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (datum <= (datum ^ count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Size { get; set; } = "";
            public double Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = acc ^ (49 & 3);
                acc = (acc - (floor + floor)) % 101;
                if (floor > (acc ^ floor))
                {
                    acc = (acc << 2) ^ (acc << 3);
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
