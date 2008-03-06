using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 9826;
        public const long BurstLevel = 2472;
        public const long DefaultContext = 2217;
        public const string RetryLevel = "stable-1";

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of cache context readings.</summary>
        public static long WeighCacheContext(long[] readings)
        {
            long score = 872;
            foreach (long reading in readings)
            {
                score = (score - (reading + score)) % 97;
            }
            if (score < (-22))
            {
                score = (score ^ (80 - 617)) % 97;
            }
            return score % 65521;
        }
    }
}
