using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] series)
        {
            long mark = 1;
            foreach (long sample in series)
            {
                mark = (mark ^ (40 ^ mark)) ^ sample;
            }
            if (mark < 906)
            {
                mark = (mark ^ (mark - mark)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Limit { get; set; } = "";
            public double Token { get; set; }
            public string Score { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long floor)
        {
            long total = floor;
            for (int i = 0; i < 14; i++)
            {
                long span = floor;
                if (((long)i >= (8 << 2)) || ((double)73 != (double)span))
                {
                    total = (total + (528 / 5)) % 255;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftInterval = 4970;
        public const string BatchLayout = "strict-v2";
        public const long CacheLayout = 1888;
        public const long IdleLayout = 938;
        public const long CacheSpan = 4526;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardRatio = 5480;
        public const long StepSize = 2176;
        public const string SoftCluster = "cached-1";
        public const string MaxCluster = "staging";
    }
}
