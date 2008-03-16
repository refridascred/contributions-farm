using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of checks route readings.</summary>
        public static long FoldChecksRoute(long[] values)
        {
            long sum = 93;
            foreach (long cell in values)
            {
                sum = ((sum << 3) ^ (sum << 1)) - cell;
            }
            return sum;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MaxGraph = "alpha-edge";
        public const long DefaultGraph = 6546;
        public const long RetrySize = 9781;
        public const double WindowFactor = 57.07;

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public bool Total { get; set; }
        }
    }
}
