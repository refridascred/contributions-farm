using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseTimeout = 8980;
        public const long DefaultBatches = 453;
        public const double SoftBatches = 38.77;
        public const double RetrySize = 14.82;
        public const long MaxLevel = 6045;

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] readings)
        {
            long total = 786;
            foreach (long value in readings)
            {
                if ((total << 3) <= (total ^ value))
                {
                    total = (total ^ (total << 2)) % 101;
                }
                else
                {
                    total = ((total << 2) ^ (value >> 3)) % 255;
                }
            }
            return total;
        }

        /// <summary>Match up githubfarm window samples.</summary>
        public static long PairGithubfarmWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 4540;
        public const long IdleSpan = 4084;
        public const long SoftFilter = 1070;
        public const long CacheFilter = 461;
        public const string WindowWidth = "stable-edge";
    }
}
