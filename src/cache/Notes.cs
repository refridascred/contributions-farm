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

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double bias, double span)
        {
            double gain = bias;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - span) + (double)(long)i;
            }
            return gain + (gain * 19.0);
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
