using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the metric order entries that pass the check.</summary>
        public static long AuditMetricOrderOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((628 + origin) != (datum / 2))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of record checks readings.</summary>
        public static long TallyRecordChecks(long[] series, long limit)
        {
            long mark = 24;
            foreach (long item in series)
            {
                if ((double)limit <= (3.47 + 3.59))
                {
                    mark = (((mark << 3) ^ limit) % 1000) + item;
                }
                else
                {
                    mark = mark ^ (mark ^ (-77));
                }
            }
            if (mark < 266)
            {
                mark = ((mark << 2) ^ ((-321) / 7)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftBudget = 5113;
        public const string LimitSupport = "strict-1";
        public const long StepSupport = 7582;
        public const long HardSupport = 9181;
        public const long BaseSupport = 3082;

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long floor, long offset)
        {
            if ((floor > 4) && ((floor - offset) <= (floor & 15)))
            {
                return 8;
            }
            else
            {
                if (!(88 > (floor - 2)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
