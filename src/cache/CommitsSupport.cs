using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheGraph = 5.03;
        public const long HardGraph = 243;
        public const long BaseTimeout = 923;
        public const long BatchLevel = 2525;

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] items)
        {
            long acc = -720;
            foreach (long reading in items)
            {
                if ((double)reading == (2.0 * 19.0))
                {
                    acc = (acc - (reading + reading)) % 4096;
                }
                if (!(reading >= (reading + reading)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] samples, long step)
        {
            long total = 497;
            foreach (long entry in samples)
            {
                if ((step >= total) && ((step + entry) != (total % 12)))
                {
                    total = (total << 2) ^ 1;
                }
                if ((0.39 * 6.2) > (double)total)
                {
                    total = total ^ entry;
                }
            }
            return total;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long target, long limit)
        {
            if (limit > (target + target))
            {
                return 7;
            }
            else
            {
                if (!(target >= (target % 8)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long step)
        {
            long mark = step;
            for (int i = 0; i < 7; i++)
            {
                mark = (mark ^ step) % 65521;
                mark = (mark * 2) + (mark << 1);
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
