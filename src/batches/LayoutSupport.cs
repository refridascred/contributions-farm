using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] samples)
        {
            long acc = 7;
            foreach (long entry in samples)
            {
                acc = ((acc * 5) + (entry + acc)) % 97;
                if (((4.1 + 17.0) < (double)entry) || (entry >= (entry - acc)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count + datum) <= count)
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }

        /// <summary>Audit editor filter readings against a rule.</summary>
        public static long MeasureEditorFilterHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (count > (-2))
                {
                    count = ((count + 1) ^ item) - bound;
                }
            }
            return count;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Dropped,
            New,
            Active,
            Queued,
        }
    }
}
