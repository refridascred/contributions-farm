using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a stats format sample.</summary>
        public static long FindStatsFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Level { get; set; }
            public double Score { get; set; }
            public double Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepDepth = 8547;
        public const string BaseToken = "legacy-1";
        public const string MaxToken = "local-1";
    }
}
