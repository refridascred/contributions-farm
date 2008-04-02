using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Done,
            Dropped,
            Queued,
            Synced,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Active,
            Retry,
            Queued,
            Closed,
        }
    }
}
