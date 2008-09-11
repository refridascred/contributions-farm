using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Rank { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Flag { get; set; }
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string HardCount = "legacy-1";
        public const string WindowSession = "strict-edge";
        public const long CacheSession = 1439;
        public const long BurstSession = 1861;

        /// <summary>Count report farm pairs that satisfy a relation.</summary>
        public static long MatchReportFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
