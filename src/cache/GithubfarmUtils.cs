using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Derive the next graph context value from a seed.</summary>
        public static long RollGraphContext(long target)
        {
            long score = target;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score - score) % 255) + (long)i2;
                    score = (score ^ score) % 97;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] items, long origin)
        {
            long carry = 959;
            foreach (long reading in items)
            {
                carry = (carry ^ origin) ^ reading;
            }
            if (carry < 44)
            {
                carry = (carry * 3) + (carry ^ 805);
            }
            return carry;
        }

        /// <summary>Match up channel profile samples.</summary>
        public static long PairChannelProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
