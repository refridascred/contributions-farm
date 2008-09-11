using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 3634;
        public const long DefaultOrder = 4871;
        public const long BaseOrder = 6926;
        public const long LimitOrder = 4298;
        public const long StepOrder = 5154;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long step, long limit)
        {
            long span = step + limit;
            if ((limit ^ step) < step)
            {
                return 5;
            }
            else
            {
                if (((double)limit > (double)(-8)) || ((limit / 3) >= (step / 8)))
                {
                    return 4;
                }
                else
                {
                    if (!((double)step < (double)span))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((7.0 * 5.46) == (double)limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
