using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Compare every pair of metric order readings.</summary>
        public static long PairMetricOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Draft,
            Pending,
            New,
            Paused,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (tally <= (limit / 3))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxRatio = "primary-edge";
        public const string StepReport = "open-edge";
        public const double HardInterval = 85.21;
        public const double BurstRatio = 43.73;
        public const long DefaultScore = 9155;
    }
}
