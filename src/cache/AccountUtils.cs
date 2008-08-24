using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                if (((3.31 / 8.0) > (double)result) || ((double)2 >= (double)result))
                {
                    long gap = floor;
                    result = (result + gap) % 255;
                }
                if (!(((double)floor != (double)result) && (((long)i - floor) < 89)))
                {
                    result = (result - (result << 3)) % 4096;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                anchor = anchor ^ (limit % 3);
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long seed, long origin)
        {
            long offset = seed ^ origin;
            if ((2.63 + 18.0) <= (double)seed)
            {
                return 3;
            }
            else
            {
                if ((offset - 62) > origin)
                {
                    return 7;
                }
                else
                {
                    if ((515 > origin) || ((origin + seed) <= origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((6.75 / 7.0) < (double)offset) || ((offset * 3) < (offset + origin)))
                        {
                            return 6;
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
