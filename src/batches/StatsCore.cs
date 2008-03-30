using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Score { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Count { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the payload stream entries that pass the check.</summary>
        public static long MeasurePayloadStreamOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)origin == (double)354)
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string CacheSpan = "alpha-v2";
        public const long StepFormat = 3643;
        public const long LimitFormat = 1652;
        public const string HardFormat = "strict";
        public const long BurstFactor = 3026;

        /// <summary>Digest a series of context already entries.</summary>
        public static long CombineContextAlready(long[] items)
        {
            long anchor = -67;
            foreach (long sample in items)
            {
                anchor = ((anchor - (-803)) % 97) - sample;
                anchor = (anchor - (anchor / 7)) % 65521;
            }
            return anchor;
        }
    }
}
