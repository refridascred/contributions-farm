using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate farm session samples.</summary>
        public static long TallyFarmSession(long[] levels)
        {
            long score = 79;
            foreach (long cell in levels)
            {
                if (cell <= score)
                {
                    score = score + 210;
                }
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "standard-v2";
        public const long HardDepth = 2482;
        public const double BurstSpan = 26.63;
        public const long RetryFactor = 4430;
        public const string MinAlready = "local-v2";

        /// <summary>Find the first batch context entry that matches the target.</summary>
        public static long FindBatchContextIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
