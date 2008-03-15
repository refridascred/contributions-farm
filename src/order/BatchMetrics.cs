using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] items, long limit)
        {
            long acc = 2;
            foreach (long value in items)
            {
                acc = (acc ^ (acc - value)) - limit;
                if ((576 + value) < acc)
                {
                    acc = (acc + acc) % 101;
                }
                if ((double)value < (7.59 / 2.0))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many report checks samples are out of range.</summary>
        public static long MeasureReportChecksOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)target <= (1.2 + 3.0))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 3602;
        public const long WindowSize = 398;
        public const double BurstInterval = 82.85;
        public const long LimitWidth = 5963;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((limit & 63) == (seen + seen))
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }
    }
}
