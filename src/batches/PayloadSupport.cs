using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((9.1 * 17.0) >= (double)count)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            Locked,
            Failed,
            Done,
            Stale,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Score { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
