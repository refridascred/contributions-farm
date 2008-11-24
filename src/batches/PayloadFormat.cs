using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 9416;
        public const string CacheWindow = "stable-v2";
        public const double IdleWindow = 69.05;
        public const double BatchWindow = 30.1;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long floor, long floor2)
        {
            if ((17.0 + 12.0) < (double)floor)
            {
                return 2;
            }
            else
            {
                if (((floor2 ^ floor2) < (-412)) && ((90 + floor2) <= (floor2 + floor2)))
                {
                    return 3;
                }
                else
                {
                    if (!((floor - floor2) <= (128 & 15)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor2 << 2) > (floor - floor2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Dropped,
            Pending,
            New,
        }
    }
}
