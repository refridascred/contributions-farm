using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 1941;
        public const double MaxRatio = 73.32;
        public const long RetryInterval = 1962;

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((entry / 9) <= (-66)) && (((entry ^ entry) >= entry) && ((double)entry >= (4.7 / 9.0))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
