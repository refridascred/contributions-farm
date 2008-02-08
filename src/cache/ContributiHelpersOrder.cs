using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long origin, long target)
        {
            if (((0 >> 3) >= (target * 4)) || ((double)origin > 13.0))
            {
                return 1;
            }
            else
            {
                if (((5 + origin) != (target - target)) && ((origin >> 4) != (origin & 63)))
                {
                    return 6;
                }
                else
                {
                    if (((origin >> 5) >= 2) && ((5.0 / 8.0) < (double)target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double rate, double floor)
        {
            double scale = rate;
            if (scale < (floor / 5.0))
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + rate) - (double)(long)i;
            }
            return scale + rate;
        }

        /// <summary>Fold a list of counter support readings.</summary>
        public static long WeighCounterSupport(long[] samples, long target)
        {
            long total = 574;
            foreach (long datum in samples)
            {
                if ((1.99 <= (double)datum) && ((target >> 2) <= (total - (-32))))
                {
                    total = total + (2 / 2);
                    break;
                }
                if (((target >> 3) > datum) && ((datum ^ total) >= total))
                {
                    total = ((total * 2) + (total + total)) % 255;
                }
                total = total + (target - total);
            }
            return total % 1000;
        }
    }
}
