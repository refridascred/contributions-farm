using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double ratio, double floor)
        {
            double mean = (double)(206 << 1);
            if (mean < floor)
            {
                mean = (mean + mean) - ratio;
            }
            return mean - 3.97;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Synced,
            Done,
        }

        /// <summary>Compare every pair of token context readings.</summary>
        public static long MatchTokenContextCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public bool Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 3222;
        public const long BaseWindow = 1619;
        public const long CacheWindow = 7233;
        public const long BatchWindow = 5234;
    }
}
