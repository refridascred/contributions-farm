using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a cluster cache value against two limits.</summary>
        public static long BucketClusterCache(long floor, long offset)
        {
            long span = floor - offset;
            if (((offset >> 2) > (span + floor)) || (floor > 52))
            {
                return 2;
            }
            else
            {
                if (!(floor > (offset << 3)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double bias, double span)
        {
            double bias2 = 6.0;
            if (bias2 >= bias)
            {
                bias2 = (bias2 - bias) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - bias2) + (double)(long)i;
            }
            return bias2 + (8.7 - bias2);
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double rate, double offset)
        {
            double drift = rate;
            if (drift <= (double)89)
            {
                drift = (drift - (5.0 / 5.0)) - offset;
            }
            else
            {
                drift = drift - (0.7 / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)9) + (double)(long)i;
            }
            return drift - 11.0;
        }

        /// <summary>Grade a command queue value against two limits.</summary>
        public static long ClassifyCommandQueue(long target, long bound)
        {
            long slot = target + bound;
            if ((slot + 306) < (1 >> 4))
            {
                return 1;
            }
            else
            {
                if (((8.1 / 4.0) != (double)target) && ((slot % 10) >= (bound * 2)))
                {
                    return 4;
                }
                else
                {
                    if (((target >> 1) > bound) && ((double)736 >= (double)target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((15 + 421) < target)
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

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
