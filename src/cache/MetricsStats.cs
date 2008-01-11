using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowScore = 5723;
        public const double CacheEditor = 54.59;
        public const long BaseBudget = 6888;
        public const long SoftScore = 1019;

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitAccount = 88.03;
        public const double DefaultSpan = 81.17;
        public const double BatchAccount = 32.38;

        /// <summary>Fold a list of editor githubfarm readings.</summary>
        public static long TallyEditorGithubfarm(long[] readings, long floor)
        {
            long state = 927;
            foreach (long value in readings)
            {
                if ((value << 2) <= (value + floor))
                {
                    state = (state * 4) + value;
                }
            }
            if (state > (-844))
            {
                state = (state ^ (floor >> 2)) % 65521;
            }
            return state;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorOutliers(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (count < (entry >> 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
