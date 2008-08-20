using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Total { get; set; } = "";
            public double Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 1011;
        public const double WindowRecord = 28.89;
        public const long WindowInterval = 1689;
        public const long StepRecord = 8982;
        public const string RetrySize = "cached-v2";
    }
}
