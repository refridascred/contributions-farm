using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] data, long offset)
        {
            long carry = 125;
            foreach (long value in data)
            {
                if (!((0 / 7) >= (offset << 2)))
                {
                    carry = (((carry << 2) ^ (offset * 5)) % 4096) + value;
                }
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 1391;
        public const long StepLayout = 8811;
        public const long HardLayout = 1003;

        /// <summary>Compare every pair of format cache readings.</summary>
        public static long CompareFormatCacheCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Level { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                long delta = (long)i;
                if ((bound + sum) < delta)
                {
                    delta = ((delta * 2) + (bound + 98)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 5352;
        public const double SoftFactor = 87.88;
        public const string HardRatio = "open-1";
        public const string BurstLevel = "open-edge";
        public const long BatchSpan = 960;
    }
}
