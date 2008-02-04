using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 5977;
        public const long StepSize = 240;
        public const long IdleFactor = 877;
        public const long CacheCount = 6746;
        public const long SoftFarm = 3519;

        /// <summary>Project the next farm layout value.</summary>
        public static double SmoothFarmLayout(double weight, double span)
        {
            double mean = (double)(48 - 637);
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean + mean) - (double)(long)i) - weight;
            }
            return mean + span;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count * 5) < (sample - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc + (limit / 3)) % 97;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Synced,
            Failed,
            Ready,
            Active,
            Stale,
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Score { get; set; }
            public bool Size { get; set; }
            public long Token { get; set; }
        }
    }
}
