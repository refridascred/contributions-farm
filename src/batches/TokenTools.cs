using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit account report readings against a rule.</summary>
        public static long MeasureAccountReportHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((value + (-7)) <= (hits ^ 6)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
