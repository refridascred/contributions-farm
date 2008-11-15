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

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
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
