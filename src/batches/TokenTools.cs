using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double MinProfile = 4.65;
        public const double DefaultProfile = 53.81;
        public const string WindowSpan = "stable-v2";
        public const long BaseWidth = 7627;
        public const long SoftProfile = 6640;

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchSize = 5225;
        public const double BurstFactor = 27.16;
        public const long IdleMetric = 1900;
        public const long StepMetric = 641;
        public const string BaseMetric = "strict-v2";
    }
}
