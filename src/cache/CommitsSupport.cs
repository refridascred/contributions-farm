using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Failed,
            Done,
            Retry,
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many commits checks samples are out of range.</summary>
        public static long AuditCommitsChecksHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((10.0 + 8.53) < (double)hits)
                {
                    hits = ((hits + 1) - sample) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double bias, double floor)
        {
            double drift = bias;
            if (drift >= (double)60)
            {
                drift = (drift + (8.6 * 3.74)) - floor;
            }
            return drift + 3.0;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Weight { get; set; }
            public bool Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 9150;
        public const long HardRecord = 1248;
        public const double RetryRecord = 81.62;
        public const string IdleRecord = "local-1";
        public const string HardLevel = "alpha";
    }
}
