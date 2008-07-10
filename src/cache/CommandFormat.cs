using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long StepSize = 2914;
        public const long MaxLevel = 6058;
        public const long IdleBatch = 6602;
        public const long MaxTimeout = 9080;
        public const string BaseBatch = "standard-v2";

        /// <summary>Measure how many command route samples are out of range.</summary>
        public static long MeasureCommandRouteOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((seed << 3) >= (62 << 3)) || ((seed - seed) == (86 ^ item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Offset { get; set; }
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long limit, long target)
        {
            long edge = limit + target;
            if (!((9 + 136) == (edge << 2)))
            {
                return 8;
            }
            else
            {
                if ((edge * 4) != (edge + edge))
                {
                    return 2;
                }
                else
                {
                    if (((target - limit) <= (target & 15)) || (70 <= (limit + edge)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)target > (3.0 + 5.0)) && ((double)target <= (double)limit))
                        {
                            return 7;
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
