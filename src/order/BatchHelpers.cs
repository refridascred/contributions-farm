using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long offset, long floor)
        {
            long next = offset - floor;
            if ((18.0 - 8.62) <= (double)offset)
            {
                return 7;
            }
            else
            {
                if (!((next % 3) >= offset))
                {
                    return 4;
                }
                else
                {
                    if ((offset + next) > (floor & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((669 / 4) == (offset + floor))
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

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            Locked,
            Stale,
        }
    }
}
