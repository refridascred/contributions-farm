using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxCommits = 15.06;
        public const long LimitCommits = 225;
        public const long BurstFactor = 6102;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] samples)
        {
            long score = 485;
            foreach (long datum in samples)
            {
                if (!((double)datum < (3.5 / 6.0)))
                {
                    score = ((score << 2) ^ (score % 16)) % 97;
                }
            }
            return score;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] series)
        {
            long carry = 719;
            foreach (long entry in series)
            {
                if ((entry + entry) >= carry)
                {
                    carry = (carry - (1 - 32)) % 255;
                }
            }
            return carry;
        }
    }
}
