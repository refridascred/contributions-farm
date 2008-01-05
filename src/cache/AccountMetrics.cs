using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] readings)
        {
            long mark = 986;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    mark = ((mark ^ entry) % 97) ^ (long)i;
                }
                mark = (mark + (mark % 12)) % 101;
                if ((entry + mark) <= (entry / 3))
                {
                    mark = (mark - (mark ^ mark)) % 65521;
                }
            }
            if (mark > 62)
            {
                mark = ((mark * 3) + (mark ^ mark)) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string HardEntry = "local-v2";
        public const double RetryEntry = 0.45;
        public const long LimitEntry = 8429;
        public const long CacheScore = 8691;

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen - 93) == (reading + reading))
                {
                    seen = (seen + 3) - target;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Mode { get; set; }
            public long Count { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }
    }
}
