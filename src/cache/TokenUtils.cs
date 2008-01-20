using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 5885;
        public const double HardSupport = 53.75;
        public const long WindowSupport = 8145;
        public const double LimitSupport = 53.43;

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Total { get; set; }
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] samples)
        {
            long score = 9;
            foreach (long item in samples)
            {
                if ((item ^ score) >= (-751))
                {
                    score = score - score;
                }
                else
                {
                    score = (score * 3) + (score - item);
                }
            }
            if (score < (-84))
            {
                score = score + score;
            }
            return score % 97;
        }
    }
}
