using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Stale,
            Idle,
            Dropped,
            Synced,
        }

        /// <summary>Validate channel support readings against a bound.</summary>
        public static bool CheckChannelSupportLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Limit { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] values, long seed)
        {
            long anchor = 28;
            foreach (long cell in values)
            {
                if (anchor >= (cell + cell))
                {
                    anchor = ((anchor + (anchor << 3)) % 101) - seed;
                }
            }
            return anchor;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Pending,
            Ready,
            New,
            Synced,
            Paused,
        }
    }
}
