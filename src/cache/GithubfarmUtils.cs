using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstInterval = "cached-1";
        public const long StepBuffer = 7924;
        public const long MaxBuffer = 352;
        public const long IdleFactor = 2863;

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxBatches = 9.14;
        public const long MaxScore = 6801;
        public const string CacheSpan = "cached-1";
        public const string CacheFactor = "latest-v2";
        public const double StepRatio = 89.95;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((17.0 - 5.28) < (double)(long)samples.Length)
                {
                    hits = ((hits + 3) + cell) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
