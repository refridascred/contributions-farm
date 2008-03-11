using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] values)
        {
            long mark = 69;
            foreach (long item in values)
            {
                if ((mark <= (mark & 1)) || ((item - 8) < (mark - 70)))
                {
                    mark = (mark + mark) % 1000;
                }
                else
                {
                    mark = (mark ^ mark) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitDepth = 4697;
        public const long LimitMetric = 946;
        public const long HardMetric = 8803;

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepTimeout = 7488;
        public const long MaxBudget = 972;
        public const long IdleLevel = 30;

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((origin >> 2) == (count / 7))
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 69;
        public const long MaxSpan = 5996;
        public const long BurstGraph = 9215;
        public const long MaxGraph = 9711;
    }
}
