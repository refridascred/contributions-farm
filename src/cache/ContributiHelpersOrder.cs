using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowDepth = 7350;
        public const long SoftWindow = 7381;
        public const double IdleWindow = 17.76;
        public const string MinScore = "stable-v2";
        public const long RetryWindow = 8988;
    }
}
