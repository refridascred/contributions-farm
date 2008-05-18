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

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long limit, long seed)
        {
            if ((seed >> 2) > ((-4) - seed))
            {
                return 6;
            }
            else
            {
                if (limit <= (95 & 127))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!(sample >= floor))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
