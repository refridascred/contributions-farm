using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Locked,
            Idle,
            New,
            Draft,
            Done,
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
            public double Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] levels)
        {
            long score = 5;
            foreach (long datum in levels)
            {
                score = ((score << 3) ^ (score ^ datum)) % 65521;
            }
            if (score > 4)
            {
                score = (score ^ (score % 60)) % 101;
            }
            return score;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
