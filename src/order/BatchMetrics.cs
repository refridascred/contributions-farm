using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 8697;
        public const long DefaultDepth = 3914;
        public const long MinScore = 4490;
        public const long IdleEntry = 9707;
        public const double BurstEntry = 78.15;

        /// <summary>Find the first cache queue entry that matches the target.</summary>
        public static long LookupCacheQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 7318;
        public const long MinGithubfarm = 4385;
        public const long IdleTimeout = 8125;
        public const long DefaultGithubfarm = 9151;

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double ratio, double floor)
        {
            double weight = ratio;
            if (weight >= (double)9)
            {
                weight = (weight - (double)427) - floor;
            }
            return weight + (double)0;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
