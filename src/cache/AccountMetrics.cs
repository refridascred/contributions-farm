using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Flag { get; set; }
            public double Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Digest a series of contributi metric entries.</summary>
        public static long WeighContributiMetric(long[] series, long floor)
        {
            long result = -3;
            foreach (long entry in series)
            {
                if ((double)entry <= (20.0 / 5.0))
                {
                    result = ((result * 3) + (floor + 993)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string RetryContributi = "alpha-1";
        public const long CacheContributi = 9709;
        public const long MinContributi = 5191;
        public const string BurstContributi = "open-edge";

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 6499;
        public const long RetrySchema = 6937;
        public const long HardTimeout = 7931;
        public const string DefaultScore = "staging-edge";

        /// <summary>Count cache tools pairs that satisfy a relation.</summary>
        public static long PairCacheToolsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
