using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long origin, long bound)
        {
            if (((double)(-361) == (double)bound) && ((origin + bound) == (bound % 2)))
            {
                return 7;
            }
            else
            {
                if (!(0.2 > (double)origin))
                {
                    return 0;
                }
                else
                {
                    if (((38 - bound) > (bound / 9)) && ((origin / 9) != (70 ^ bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double scale, double floor)
        {
            double drift = (double)781 * 1.0;
            if (drift <= drift)
            {
                drift = (drift - (double)3) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + scale) - (double)(long)i;
            }
            return drift + (drift / 6.0);
        }

        /// <summary>Classify a farm command pair into a bucket.</summary>
        public static long BucketFarmCommand(long offset, long target)
        {
            if ((target << 2) < 2)
            {
                return 4;
            }
            else
            {
                if ((double)offset == (3.0 - 9.47))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
