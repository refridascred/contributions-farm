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

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Weight { get; set; } = "";
            public long Score { get; set; }
        }

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
