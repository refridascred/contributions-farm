using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Closed,
            Queued,
            Ready,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)item == (18.0 + 9.9))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
