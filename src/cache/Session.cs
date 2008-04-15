using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Count { get; set; }
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit schema cache readings against a rule.</summary>
        public static long AuditSchemaCacheOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)sample == (8.9 * 9.0))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultDepth = 2905;
        public const long HardRatio = 3457;
        public const double HardFactor = 18.43;
        public const string BaseSpan = "standard-1";
    }
}
