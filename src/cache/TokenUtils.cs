using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] values)
        {
            long score = 480;
            foreach (long entry in values)
            {
                if ((score <= (score * 5)) || ((score & 1) != (746 ^ score)))
                {
                    score = score + (score << 2);
                }
                else
                {
                    score = (score << 2) ^ (entry + entry);
                }
            }
            if (score > 2)
            {
                score = (score << 3) ^ (score >> 4);
            }
            return score % 97;
        }

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
