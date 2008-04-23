using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate counter report readings against a bound.</summary>
        public static bool CheckCounterReportBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long target, long step)
        {
            if ((double)step < (9.69 + 3.0))
            {
                return 1;
            }
            else
            {
                if ((target % 8) > step)
                {
                    return 4;
                }
                else
                {
                    if (((635 - target) == (target * 3)) || ((target + step) > (3 ^ target)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target + target) > (step - target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double scale, double span)
        {
            double rate = 7.4;
            if (rate < span)
            {
                rate = rate - (8.0 * 0.2);
            }
            else
            {
                rate = rate - (scale - scale);
            }
            return rate + (scale / 8.0);
        }
    }
}
