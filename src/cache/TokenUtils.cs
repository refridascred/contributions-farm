using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two entry command measurements.</summary>
        public static double AdjustEntryCommand(double rate, double floor)
        {
            double scale = (double)(98 - 5);
            if (scale > rate)
            {
                scale = scale - (double)9;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - floor) - (double)(long)i;
            }
            return scale - floor;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long bound, long origin)
        {
            if (((-77) < origin) && ((4.75 * 5.0) <= (8.0 / 4.0)))
            {
                return 0;
            }
            else
            {
                if (!((bound - origin) < origin))
                {
                    return 3;
                }
                else
                {
                    if (((origin ^ bound) >= (origin - origin)) || ((origin + 7) < origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((double)bound < (1.95 * 4.2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Retry,
            Failed,
            New,
        }
    }
}
