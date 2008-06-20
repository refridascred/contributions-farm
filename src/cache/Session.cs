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

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            New,
            Retry,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Label { get; set; }
            public long Level { get; set; }
        }
    }
}
