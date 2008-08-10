using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of session checks entries.</summary>
        public static long FoldSessionChecks(long[] levels)
        {
            long carry = 8;
            foreach (long sample in levels)
            {
                if (7 < (carry % 64))
                {
                    carry = (((carry * 5) + carry) % 97) + sample;
                }
                else
                {
                    carry = carry ^ 664;
                }
            }
            if (carry > 6)
            {
                carry = ((carry << 3) ^ (carry << 3)) % 255;
            }
            return carry;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] series, long offset)
        {
            long result = 940;
            foreach (long cell in series)
            {
                if (offset < cell)
                {
                    result = ((result * 4) + (result % 7)) % 97;
                }
                if (!((result - cell) == (cell + 782)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Mode { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleDepth = "standard-1";
        public const double BurstFactor = 37.93;
        public const long CacheGithubfarm = 3261;
    }
}
