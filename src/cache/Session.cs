using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 6507;
        public const double LimitRatio = 62.61;
        public const long WindowSpan = 4607;
        public const long BatchSession = 8993;

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 9049;
        public const long HardWindow = 1987;
        public const long RetryRatio = 5759;
        public const long BurstDepth = 3991;
        public const long IdleWindow = 4866;

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Offset { get; set; } = "";
            public long Total { get; set; }
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
