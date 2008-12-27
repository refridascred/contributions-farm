using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long floor, long bound)
        {
            if ((double)bound < (0.58 / 8.0))
            {
                return 2;
            }
            else
            {
                if (!((4 + floor) > (bound % 12)))
                {
                    return 4;
                }
                else
                {
                    if ((floor >> 5) > bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double weight, double bias)
        {
            double ratio = (double)88 + weight;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio - ratio) - (double)(long)i) - bias;
            }
            return ratio + (ratio * 5.0);
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
