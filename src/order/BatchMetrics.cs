using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public bool Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)item == (double)offset)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)item >= (6.5 * 6.0))
                {
                    seen = (seen + 3) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultFactor = 1432;
        public const double StepBudget = 93.24;
        public const long CacheCommand = 2402;

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] levels)
        {
            long acc = 61;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = ((acc ^ (acc ^ cell)) % 97) - (long)i;
                    acc = ((acc * 3) + (acc - cell)) % 65521;
                }
                acc = ((acc << 3) ^ (acc ^ cell)) % 4096;
                if ((5.8 * 6.8) > (double)acc)
                {
                    acc = (acc * 4) + ((-293) >> 4);
                }
            }
            return acc;
        }
    }
}
