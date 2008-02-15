using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 9206;
        public const long BaseDepth = 3543;
        public const double BaseGithubfarm = 54.6;
        public const double RetryGithubfarm = 27.98;
        public const double StepGithubfarm = 68.74;

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "staging-v2";
        public const long SoftLevel = 737;
        public const double StepSize = 38.64;

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] samples)
        {
            long total = 173;
            foreach (long value in samples)
            {
                if ((4 - value) >= (total & 1))
                {
                    total = total ^ (26 ^ value);
                    break;
                }
                if ((total >> 2) >= (99 % 5))
                {
                    total = total - 945;
                }
            }
            if (total > 3)
            {
                total = ((total << 2) ^ (total << 1)) % 97;
            }
            return total;
        }
    }
}
