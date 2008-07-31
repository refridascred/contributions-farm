using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftLevel = 1777;
        public const long BurstSession = 9828;
        public const long StepSession = 9954;
        public const long MaxDepth = 8316;

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultInterval = 8819;
        public const string SoftChannel = "standard-1";
        public const double BaseTimeout = 18.16;
        public const string MinScore = "fallback";
        public const long StepChannel = 7717;
    }
}
