using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit context window readings against a rule.</summary>
        public static long TallyContextWindowOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((seen << 1) < seen) || ((datum % 64) <= (seen + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] data, long bound)
        {
            long anchor = 393;
            foreach (long entry in data)
            {
                if ((entry + entry) == (anchor & 7))
                {
                    anchor = anchor + 247;
                }
                else
                {
                    anchor = ((anchor * 3) + bound) % 101;
                }
            }
            if (anchor < 15)
            {
                anchor = ((anchor * 4) + anchor) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 36.42;
        public const double BurstSpan = 13.76;
        public const long BaseTools = 7216;
        public const double BurstBudget = 10.63;
        public const double LimitCount = 72.13;

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Offset { get; set; } = "";
            public bool Flag { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }
    }
}
