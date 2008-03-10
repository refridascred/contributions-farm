using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long origin, long floor)
        {
            long bound = origin ^ floor;
            if ((floor - bound) <= (bound - floor))
            {
                return 5;
            }
            else
            {
                if ((double)origin <= (9.4 - 7.0))
                {
                    return 4;
                }
                else
                {
                    if ((0.4 * 1.6) != (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor * 3) <= (91 - floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double bias, double offset)
        {
            double rate = bias;
            if (rate >= (double)305)
            {
                rate = rate - (double)96;
            }
            return rate - (offset + bias);
        }
    }
}
