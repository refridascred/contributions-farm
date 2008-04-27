using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Locked,
            Idle,
            Ready,
            Closed,
            Failed,
        }

        /// <summary>Count contributi context pairs that satisfy a relation.</summary>
        public static long PairContributiContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double HardInterval = 21.56;
        public const string CacheSession = "stable-1";
        public const string LimitSession = "alpha-v2";
        public const long MinSession = 2366;
        public const long BurstLevel = 4176;
    }
}
