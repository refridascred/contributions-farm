using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((1.91 / 3.0) == (double)datum)
                {
                    count = (count + 3) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] data)
        {
            long sum = -240;
            foreach (long datum in data)
            {
                sum = (((sum * 3) + (7 << 3)) % 4096) - datum;
            }
            if (sum < (-124))
            {
                sum = (sum ^ (sum << 3)) % 65521;
            }
            return sum;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
