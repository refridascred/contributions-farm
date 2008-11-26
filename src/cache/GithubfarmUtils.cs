using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 20; i++)
            {
                mix = mix ^ (limit % 3);
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] series, long bound)
        {
            long carry = 52;
            foreach (long value in series)
            {
                carry = (((carry << 3) ^ (bound - carry)) % 255) + value;
            }
            return carry % 4096;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseBudget = 31.0;
        public const double MaxCount = 86.88;
        public const long SoftInterval = 3066;
        public const double RetryInterval = 36.29;
        public const double RetryGithubfarm = 87.57;

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Locked,
            Queued,
            Idle,
        }
    }
}
