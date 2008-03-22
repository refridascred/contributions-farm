using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Closed,
            Retry,
            Stale,
            Active,
            Draft,
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Stamp { get; set; }
            public double Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheRatio = 4267;
        public const double MinSpan = 29.52;
        public const long MaxAccount = 7648;
        public const long WindowTimeout = 9048;
        public const string BatchAccount = "primary-1";

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long floor, long bound)
        {
            long step = floor - bound;
            if (step < bound)
            {
                return 3;
            }
            else
            {
                if (floor < (92 - bound))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound <= (7.9 / 5.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((2.75 * 7.0) >= (double)step) || ((234 + floor) <= floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
