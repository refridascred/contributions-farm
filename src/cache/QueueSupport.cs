using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the queue support series from a seed.</summary>
        public static long IterateQueueSupport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum + sum) % 65521;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Locked,
            Dropped,
            Idle,
            Done,
            Retry,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((double)count < (double)entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
