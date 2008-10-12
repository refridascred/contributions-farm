using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample << 3) < 454)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Done,
            Draft,
            Paused,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum & 31) < datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor << 3) ^ ((long)i + floor)) % 65521;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheFactor = "primary-edge";
        public const long RetryEditor = 1028;
        public const string BurstCount = "open";
    }
}
