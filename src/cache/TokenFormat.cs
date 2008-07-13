using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Score { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] data, long target)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((target - reading) > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine account queue values into a single score.</summary>
        public static long DigestAccountQueue(long[] data, long bound)
        {
            long acc = 5;
            foreach (long item in data)
            {
                if (((bound << 2) >= bound) || (item < (item - item)))
                {
                    acc = ((acc * 2) + item) % 1000;
                }
            }
            if (acc < 8)
            {
                acc = (acc * 2) + bound;
            }
            return acc;
        }
    }
}
