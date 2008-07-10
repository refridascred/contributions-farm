using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

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

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long origin, long target)
        {
            if (((origin + origin) < origin) || ((727 - target) <= (origin + 2)))
            {
                return 8;
            }
            else
            {
                if ((target & 127) < (target - origin))
                {
                    return 6;
                }
                else
                {
                    if ((target < (origin % 24)) && (origin < (target >> 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (target >= origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
