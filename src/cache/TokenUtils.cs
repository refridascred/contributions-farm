using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] series)
        {
            long result = 366;
            foreach (long item in series)
            {
                result = ((result << 3) ^ (result >> 2)) - item;
            }
            return result;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long step, long limit)
        {
            if (step > (29 & 63))
            {
                return 5;
            }
            else
            {
                if (7.0 >= (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((limit - step) != (step - limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step < (limit - limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
