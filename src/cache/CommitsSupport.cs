using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry + (-576)) <= (long)data.Length)
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitRatio = 7409;
        public const double LimitNotes = 53.2;
        public const double BaseNotes = 11.42;
        public const long HardFactor = 1044;

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Offset { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Derive the next editor batch value from a seed.</summary>
        public static long IterateEditorBatch(long floor)
        {
            long state = floor;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Label { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }
    }
}
