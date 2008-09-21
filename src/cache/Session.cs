using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstLevel = 1335;
        public const long CacheContributi = 4024;
        public const long MaxContributi = 2904;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Score { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstScore = 21.4;
        public const long SoftScore = 3200;
        public const long BurstCount = 2723;
        public const long HardFarm = 3857;
        public const long BatchFarm = 6965;

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
