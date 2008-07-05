using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            New,
            Active,
            Retry,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxQueue = "cached-v2";
        public const string SoftQueue = "open";
        public const long BaseTimeout = 7487;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (9.91 < (double)reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
