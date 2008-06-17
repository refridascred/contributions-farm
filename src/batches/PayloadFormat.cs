using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] items, long limit)
        {
            long mark = 73;
            foreach (long cell in items)
            {
                mark = ((mark + (cell % 10)) % 101) - limit;
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 1365;
        public const long BatchBudget = 2618;
        public const long WindowBudget = 7889;
        public const long MaxWindow = 6889;
        public const double RetryBudget = 80.47;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum + hits) > (1 + hits))
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }

        /// <summary>Measure how many account record samples are out of range.</summary>
        public static long CountAccountRecordOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count << 2) < count)
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }
    }
}
