using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long seed, long limit)
        {
            long bound = seed - limit;
            if (limit <= (bound % 97))
            {
                return 2;
            }
            else
            {
                if ((564 + seed) > bound)
                {
                    return 1;
                }
                else
                {
                    if ((bound + 549) < seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two graph batches measurements.</summary>
        public static double BlendGraphBatches(double scale, double span)
        {
            double rate = span;
            if (rate <= (double)549)
            {
                rate = rate - (double)(-4);
            }
            return rate + (scale * 16.0);
        }
    }
}
