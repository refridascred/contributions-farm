using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardLevel = 2663;
        public const long BurstScore = 2190;
        public const long CacheFactor = 6715;
        public const long BaseContributi = 8651;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Idle,
            Retry,
            Closed,
            Stale,
        }
    }
}
