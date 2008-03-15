using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Ready,
            Active,
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitTimeout = "local-v2";
        public const long DefaultProfile = 1002;
        public const string MaxProfile = "strict-1";
        public const double RetryProfile = 35.01;
    }
}
