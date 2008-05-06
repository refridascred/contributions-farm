using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 7924;
        public const long BaseCluster = 5057;
        public const long RetryCluster = 2093;
        public const long MinRatio = 1878;
        public const double DefaultCluster = 64.36;

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] samples, long bound)
        {
            long sum = -503;
            foreach (long item in samples)
            {
                if ((double)item <= (double)bound)
                {
                    sum = (sum - item) % 255;
                }
            }
            if (sum < 883)
            {
                sum = ((sum << 3) ^ sum) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 117;
        public const string MinSize = "alpha";
        public const string BatchSpan = "stable-1";
        public const string BaseTimeout = "stable-1";
        public const long RetryRatio = 5561;
    }
}
