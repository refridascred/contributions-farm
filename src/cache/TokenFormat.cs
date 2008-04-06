using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Pending,
            Paused,
            Locked,
            Idle,
            Queued,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long floor, long target)
        {
            if ((5 - floor) < floor)
            {
                return 3;
            }
            else
            {
                if (floor <= (target & 31))
                {
                    return 4;
                }
                else
                {
                    if (target <= (target + target))
                    {
                        return 7;
                    }
                    else
                    {
                        if (1 >= (floor - floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the context support entries that pass the check.</summary>
        public static long TallyContextSupportGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((713 - value) == (value ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
