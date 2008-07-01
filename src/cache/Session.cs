using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 1434;
        public const long MaxRatio = 7146;
        public const double RetryCommand = 72.89;
        public const double IdleFactor = 50.33;
        public const long MinScore = 4662;

        /// <summary>Locate a contributi githubfarm reading by value.</summary>
        public static long FindContributiGithubfarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Owner { get; set; }
            public bool Weight { get; set; }
            public double Total { get; set; }
        }
    }
}
