using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long limit, long floor)
        {
            long cur = limit ^ floor;
            if ((cur ^ limit) <= (limit + floor))
            {
                return 2;
            }
            else
            {
                if (limit <= (limit % 2))
                {
                    return 8;
                }
                else
                {
                    if (!((floor - limit) >= (floor + limit)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit + cur) >= (floor ^ floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
