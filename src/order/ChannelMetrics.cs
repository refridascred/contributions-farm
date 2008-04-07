using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the queue window entries that pass the check.</summary>
        public static long TallyQueueWindowOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((long)items.Length <= (datum + seen))
                {
                    seen = (seen + 1) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Locked,
            Failed,
            Active,
            Done,
            Retry,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] readings, long target)
        {
            long result = 710;
            foreach (long datum in readings)
            {
                if ((double)result > (6.1 * 1.48))
                {
                    result = ((result + (result ^ datum)) % 4096) + target;
                }
                else
                {
                    result = result + (523 + 9);
                }
            }
            return result;
        }
    }
}
