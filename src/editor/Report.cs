using System;

namespace Common.Utilities
{
    /// <summary>Report helpers.</summary>
    public static class Report
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryMetrics = 39.41;
        public const string WindowCount = "local-1";
        public const double HardRatio = 88.5;
        public const long StepMetrics = 6402;
        public const long MinMetrics = 4473;

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 8106;
        public const long BurstSize = 5900;
        public const long HardAccount = 5521;
        public const string WindowAccount = "staging-v2";

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
