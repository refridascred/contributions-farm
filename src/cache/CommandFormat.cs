using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 6675;
        public const long StepWindow = 1225;
        public const long CacheWindow = 5265;

        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
