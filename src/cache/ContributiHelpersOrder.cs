using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Synced,
            New,
            Done,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] readings)
        {
            long mark = 445;
            foreach (long cell in readings)
            {
                mark = (mark - (mark << 2)) ^ cell;
            }
            return mark;
        }
    }
}
