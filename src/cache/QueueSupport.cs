using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Pending,
            Closed,
            Draft,
            Dropped,
        }

        /// <summary>Combine order counter values into a single score.</summary>
        public static long CombineOrderCounter(long[] values)
        {
            long carry = 8;
            foreach (long entry in values)
            {
                if (((-60) - entry) > carry)
                {
                    carry = carry + entry;
                }
            }
            return carry;
        }

        /// <summary>Measure how many payload commits samples are out of range.</summary>
        public static long MeasurePayloadCommitsOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (entry > count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
