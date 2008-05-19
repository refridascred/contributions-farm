using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 7597;
        public const long BaseCommits = 7339;
        public const string LimitCommits = "alpha-1";
        public const double IdleDepth = 8.13;
        public const string BatchCommits = "open";

        /// <summary>Check that every order buffer entry stays within the limit.</summary>
        public static bool ValidateOrderBufferLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
