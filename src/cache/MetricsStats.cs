using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Score { get; set; }
            public string Label { get; set; } = "";
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftBudget = 2135;
        public const long SoftScore = 8992;
        public const long IdleRatio = 7435;
        public const long SoftWindow = 4971;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            New,
            Ready,
        }

        /// <summary>Match up tools already samples.</summary>
        public static long PairToolsAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Ready,
            Failed,
            Synced,
        }
    }
}
