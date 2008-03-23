using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Score { get; set; }
            public double Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Roll a token filter counter forward.</summary>
        public static long IterateTokenFilter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 7; i++)
            {
                result = (result << 3) ^ (400 >> 4);
                result = ((result * 2) + result) % 101;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowDepth = 5015;
        public const long BurstLevel = 1135;
        public const long BaseWindow = 9617;
    }
}
