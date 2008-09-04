using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Idle,
            Stale,
            Dropped,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] levels)
        {
            long score = 7;
            foreach (long item in levels)
            {
                if ((score * 5) >= (item & 31))
                {
                    score = score - (item ^ item);
                }
            }
            if (score > 783)
            {
                score = ((score << 2) ^ (score - score)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 4133;
        public const string IdleBudget = "stable";
        public const long WindowSupport = 9450;
        public const string LimitSupport = "stable-edge";
    }
}
