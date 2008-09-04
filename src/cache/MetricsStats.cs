using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchSize = 3944;
        public const string BatchTimeout = "latest";
        public const long StepChannel = 3866;
        public const long BaseSize = 5545;
        public const double RetryCount = 13.7;

        /// <summary>Audit already window readings against a rule.</summary>
        public static long MeasureAlreadyWindowHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item - seen) <= (target + target))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] values)
        {
            long acc = 376;
            foreach (long entry in values)
            {
                if ((acc - entry) == (entry + entry))
                {
                    acc = (acc * 4) + acc;
                }
                if (entry >= (acc % 2))
                {
                    acc = (acc - (entry + entry)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Pending,
            Done,
        }
    }
}
