using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string HardLayout = "staging-edge";
        public const long StepLayout = 6608;
        public const long BatchLayout = 4901;
        public const long SoftSpan = 6674;
        public const double LimitLayout = 40.31;

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinStream = 41.32;
        public const long BaseStream = 311;
        public const double MaxFactor = 95.73;
        public const long HardFactor = 4543;
        public const string IdleStream = "cached-edge";

        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
