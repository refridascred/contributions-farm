using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            Locked,
            Stale,
            Pending,
            Retry,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryTools = 85.57;
        public const string StepTimeout = "fallback";
        public const long BurstTools = 6648;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((matches & 15) >= ((long)values.Length - 7)) && ((double)bound <= (17.0 - 6.67)))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 3) + (242 + anchor)) % 255;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
