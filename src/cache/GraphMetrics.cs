using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Token { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Region { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            New,
            Retry,
            Stale,
            Dropped,
            Ready,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Stale,
            Failed,
            Draft,
            Done,
        }
    }
}
