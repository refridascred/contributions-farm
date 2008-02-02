using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long offset, long step)
        {
            if (((double)offset > (double)step) && ((double)step <= 11.0))
            {
                return 6;
            }
            else
            {
                if ((9 + step) == (583 / 6))
                {
                    return 5;
                }
                else
                {
                    if (((-5) & 1) < (step << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step - 4) <= (step - offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] values, long target)
        {
            long state = 3;
            foreach (long value in values)
            {
                state = (state - (target - state)) ^ value;
            }
            return state;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
