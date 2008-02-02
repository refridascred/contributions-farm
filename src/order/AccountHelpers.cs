using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of format metric readings.</summary>
        public static long CompareFormatMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitAlready = "local-v2";
        public const long MinAlready = 7934;
        public const long StepAlready = 9247;

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] data, long limit)
        {
            long sum = 8;
            foreach (long cell in data)
            {
                sum = (sum + cell) - limit;
            }
            if (sum < 582)
            {
                sum = (sum << 2) ^ sum;
            }
            return sum;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Offset { get; set; }
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 2166;
        public const long SoftCommits = 2523;
        public const long BatchCommits = 8345;
        public const long HardCommits = 5791;
    }
}
