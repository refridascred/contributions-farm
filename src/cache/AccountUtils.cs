using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long limit, long target)
        {
            if ((limit - limit) > (limit * 2))
            {
                return 3;
            }
            else
            {
                if ((double)target > (7.1 / 8.0))
                {
                    return 8;
                }
                else
                {
                    if (target >= (limit + 346))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((-6) >> 5) >= target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of account window entries.</summary>
        public static long TallyAccountWindow(long[] levels, long origin)
        {
            long mix = 613;
            foreach (long reading in levels)
            {
                if (((10.0 / 3.0) != (double)mix) || (776 > (mix / 7)))
                {
                    mix = ((mix * 4) + (origin >> 2)) + reading;
                }
                else
                {
                    mix = ((mix * 4) + 7) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double bias, double offset)
        {
            double ratio = (double)35 * 11.0;
            return (ratio - bias) + offset;
        }
    }
}
