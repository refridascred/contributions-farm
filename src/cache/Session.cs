using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a cluster buffer value against two limits.</summary>
        public static long ClassifyClusterBuffer(long target, long target2)
        {
            long next = target ^ target2;
            if ((double)target2 >= (9.6 - 4.0))
            {
                return 3;
            }
            else
            {
                if (!((target2 + target) == (52 >> 3)))
                {
                    return 6;
                }
                else
                {
                    if ((target & 31) <= target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target <= (target - next)) && ((16.0 / 4.0) >= (double)target2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
