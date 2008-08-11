using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 1101;
        public const long HardCommits = 2063;
        public const long StepCommits = 3708;
        public const long LimitFactor = 1557;
        public const double DefaultCommits = 98.42;

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first batches report entry that matches the target.</summary>
        public static long FindBatchesReportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double IdleToken = 92.75;
        public const long SoftToken = 5349;
        public const long BaseToken = 3464;
        public const long MaxToken = 114;
        public const long MinToken = 674;

        /// <summary>Define filter limits and defaults.</summary>
        public const string BatchLevel = "cached";
        public const double HardFilter = 95.37;
        public const long MaxFactor = 4270;
        public const long RetryFilter = 715;
        public const double DefaultFactor = 39.95;

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
