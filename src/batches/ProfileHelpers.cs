using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Token { get; set; }
            public bool Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Iterate the cache session series from a seed.</summary>
        public static long IterateCacheSession(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Retry,
            Stale,
            Paused,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] series, long origin)
        {
            long mark = -20;
            foreach (long reading in series)
            {
                if ((origin - origin) < (582 & 1))
                {
                    mark = (((mark << 2) ^ (origin - mark)) % 1000) ^ reading;
                }
                else
                {
                    mark = ((mark << 2) ^ (origin * 3)) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 9404;
        public const long HardCache = 4104;
        public const long StepCache = 34;

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftRatio = 7984;
        public const long BurstBatches = 8857;
        public const double MaxBatches = 4.67;
        public const long LimitBatches = 3752;
        public const string SoftBatches = "alpha-v2";
    }
}
