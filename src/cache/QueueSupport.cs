using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Pending,
            Synced,
            Dropped,
            Queued,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate format command samples.</summary>
        public static long TotalFormatCommand(long[] data)
        {
            long sum = 39;
            foreach (long datum in data)
            {
                if ((double)sum == (5.46 / 6.0))
                {
                    sum = ((sum << 2) ^ (datum * 4)) % 101;
                }
            }
            return sum;
        }
    }
}
