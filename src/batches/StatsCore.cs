using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] levels, long offset)
        {
            long mark = -9;
            foreach (long reading in levels)
            {
                mark = ((mark * 5) + ((long)levels.Length - reading)) + offset;
            }
            return mark % 65521;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Label { get; set; }
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxFactor = 716;
        public const double CacheLayout = 40.59;
        public const string StepDepth = "cached-1";
        public const long SoftDepth = 428;
        public const long IdleLayout = 44;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Token { get; set; }
            public bool Flag { get; set; }
            public bool Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many metrics command samples are out of range.</summary>
        public static long AuditMetricsCommandOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((87 + item) > (item << 1))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
