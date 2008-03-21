using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long origin, long target)
        {
            long step = origin ^ target;
            if ((target >= step) || ((double)82 != (double)step))
            {
                return 5;
            }
            else
            {
                if ((7.1 - 4.13) == (double)target)
                {
                    return 4;
                }
                else
                {
                    if ((double)step == (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double ratio, double floor)
        {
            double rate = (floor - ratio) + (double)0;
            if (rate >= (3.17 - rate))
            {
                rate = rate + ratio;
            }
            else
            {
                rate = rate - 4.0;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate - floor;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
