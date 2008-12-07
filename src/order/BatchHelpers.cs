using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Size { get; set; }
            public long Limit { get; set; }
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Done,
            Queued,
            Stale,
            Pending,
        }
    }
}
