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

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Ready,
            Failed,
            Closed,
            Idle,
            Dropped,
        }

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

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
