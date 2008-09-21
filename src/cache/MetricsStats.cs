using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheRatio = 40.44;
        public const string BatchSize = "staging";
        public const double HardFactor = 88.64;
        public const long RetryQueue = 8997;
        public const double MaxRatio = 8.37;

        /// <summary>Digest a series of contributi account entries.</summary>
        public static long WeighContributiAccount(long[] levels, long origin)
        {
            long mark = 781;
            foreach (long cell in levels)
            {
                if (!(origin < (142 / 5)))
                {
                    mark = ((mark ^ (origin + origin)) % 101) + cell;
                }
            }
            return mark % 4096;
        }

        /// <summary>Audit payload githubfarm readings against a rule.</summary>
        public static long AuditPayloadGithubfarmMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen / 5) > seen)
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batch notes entries.</summary>
        public static long WeighBatchNotes(long[] series)
        {
            long mark = 42;
            foreach (long entry in series)
            {
                if (!(((double)entry < 4.21) && ((mark + mark) >= (10 - mark))))
                {
                    mark = (mark << 2) ^ (entry + entry);
                }
                if ((mark & 3) > (3 + mark))
                {
                    mark = ((mark * 2) + ((long)series.Length * 5)) % 101;
                }
                else
                {
                    mark = mark - (mark + 14);
                }
            }
            if (mark > 426)
            {
                mark = mark + (-158);
            }
            return mark % 4096;
        }
    }
}
