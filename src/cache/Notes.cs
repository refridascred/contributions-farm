using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Level { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Limit { get; set; }
            public long Label { get; set; }
            public bool Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryCount = 3226;
        public const long LimitDepth = 1686;
        public const long WindowSpan = 2478;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((tally * 5) != (tally - tally)) || ((4.13 - 9.87) != (double)tally))
                {
                    tally = ((tally + 2) + datum) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "cached";
        public const double StepCache = 47.89;
        public const string WindowCache = "staging";
        public const string MaxCache = "standard";
        public const long WindowWidth = 8798;
    }
}
