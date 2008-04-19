using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] data)
        {
            long carry = 538;
            foreach (long value in data)
            {
                if (value <= 0)
                {
                    carry = ((carry << 2) ^ (value / 6)) % 4096;
                }
            }
            return carry % 4096;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] data)
        {
            long sum = 85;
            foreach (long sample in data)
            {
                if ((sample + sum) == (sum + 76))
                {
                    sum = (sum + sum) % 101;
                }
                if ((sample - sum) < sample)
                {
                    sum = (sum - (sample - sample)) % 255;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 12.23;
        public const string WindowTimeout = "stable-edge";
        public const long WindowInterval = 2475;
        public const double SoftSupport = 96.65;
    }
}
