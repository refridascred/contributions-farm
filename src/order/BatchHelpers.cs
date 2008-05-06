using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 5598;
        public const long IdleCount = 4387;
        public const string MaxTimeout = "open-1";
        public const string MinInterval = "local-v2";
        public const string CacheReport = "stable";

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinSize = 8927;
        public const long MinBudget = 366;
        public const string StepScore = "strict-1";
    }
}
