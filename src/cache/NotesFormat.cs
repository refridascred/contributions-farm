using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long floor, long floor2)
        {
            if (((floor + floor) == (832 * 3)) || (floor <= (floor << 1)))
            {
                return 7;
            }
            else
            {
                if ((double)floor2 > (6.0 - 10.0))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Pending,
            Dropped,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Level { get; set; }
            public long Token { get; set; }
        }
    }
}
