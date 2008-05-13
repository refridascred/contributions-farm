using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Queued,
            Draft,
            New,
            Dropped,
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] values, long floor)
        {
            long mark = 908;
            foreach (long reading in values)
            {
                mark = (((mark * 4) + (mark & 15)) - reading) - floor;
            }
            return mark;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Draft,
            Paused,
            Retry,
            Ready,
            Closed,
        }
    }
}
