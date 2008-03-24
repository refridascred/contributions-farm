using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Locked,
            Synced,
            Retry,
            New,
            Paused,
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BaseScore = "strict-edge";
        public const long LimitBudget = 1320;
        public const long StepDepth = 7632;
        public const long BatchCount = 768;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Ready,
            Dropped,
            Locked,
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Pending,
            Dropped,
            Idle,
            Failed,
            Active,
        }
    }
}
