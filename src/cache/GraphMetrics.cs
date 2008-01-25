using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardBatch = "standard-1";
        public const double MaxBatch = 80.5;
        public const double HardRatio = 72.89;
        public const double CacheSize = 97.36;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Locked,
            Idle,
            Queued,
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!(cell < (cell % 24)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
