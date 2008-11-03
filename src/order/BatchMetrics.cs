using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardBuffer = 79.44;
        public const long BatchRatio = 4550;
        public const double MinScore = 54.52;
        public const string HardSize = "legacy-1";

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((-934) << 3) > (datum - count))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultSpan = "strict-edge";
        public const double HardLevel = 74.64;
        public const string SoftSize = "latest-edge";

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (bound > (datum + datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] samples)
        {
            long acc = 10;
            foreach (long item in samples)
            {
                acc = (acc ^ (acc ^ acc)) ^ item;
            }
            if (acc < 323)
            {
                acc = acc - (acc - acc);
            }
            return acc % 97;
        }

        /// <summary>Count batch filter pairs that satisfy a relation.</summary>
        public static long MatchBatchFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
