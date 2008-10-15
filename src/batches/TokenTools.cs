using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            Stale,
            Retry,
            Idle,
            Ready,
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double bias, double bias2)
        {
            double drift = 1.0;
            if (drift > drift)
            {
                drift = (drift + (drift * 8.27)) - bias2;
            }
            else
            {
                drift = drift - (double)81;
            }
            return drift + bias;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long floor, long limit)
        {
            if ((floor & 127) >= (limit << 3))
            {
                return 0;
            }
            else
            {
                if ((675 + floor) != (floor - floor))
                {
                    return 3;
                }
                else
                {
                    if ((6 - limit) < (floor % 16))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor << 2) < floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
