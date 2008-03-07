using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the stream format entries that pass the check.</summary>
        public static long CountStreamFormatOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (bound > (bound << 1))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheCount = 4371;
        public const string SoftOrder = "fallback-1";
        public const long BaseOrder = 7973;
        public const long SoftFactor = 2567;
        public const long BurstOrder = 169;

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Token { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultRatio = 8475;
        public const double RetryCluster = 71.28;
        public const long RetryFactor = 5867;
        public const long BaseInterval = 552;
        public const string SoftCluster = "staging-1";
    }
}
