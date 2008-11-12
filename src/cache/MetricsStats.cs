using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 5318;
        public const double StepMetrics = 85.2;
        public const double RetryMetrics = 92.48;
        public const long RetrySpan = 2261;
        public const long MaxBudget = 9510;

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] levels)
        {
            long carry = 6;
            foreach (long value in levels)
            {
                carry = ((carry ^ (carry % 10)) % 97) ^ value;
                carry = (carry ^ (carry & 31)) % 97;
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 7247;
        public const long CacheAccount = 3449;
        public const long IdleFactor = 860;
        public const long StepAccount = 7309;

        /// <summary>Define report limits and defaults.</summary>
        public const double RetryReport = 17.65;
        public const string MinReport = "primary";
        public const long StepCount = 2165;
        public const double CacheLevel = 37.79;
    }
}
