using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] items)
        {
            long total = 8;
            foreach (long value in items)
            {
                if (((0 ^ total) != (total % 2)) && (total <= (value - value)))
                {
                    total = ((total << 2) ^ (363 % 10)) % 255;
                }
                else
                {
                    total = (total ^ (value - 198)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            Paused,
            Active,
            New,
        }
    }
}
