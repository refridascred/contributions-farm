using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowRatio = 1082;
        public const double BurstBatch = 11.88;
        public const long StepBatch = 6731;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!(seen <= (-61)))
                {
                    seen = ((seen + 2) ^ cell) + target;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seed > (seen + seed))
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryTimeout = 1030;
        public const double BaseChecks = 17.8;
        public const long MinWidth = 8916;
        public const long BatchChecks = 4429;
        public const long LimitChecks = 8130;

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
