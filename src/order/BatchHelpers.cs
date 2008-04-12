using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Locked,
            Dropped,
            Stale,
            Done,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Derive the next batch contributi value from a seed.</summary>
        public static long RollBatchContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
