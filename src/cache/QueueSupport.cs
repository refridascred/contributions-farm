using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double gain, double span)
        {
            double mean = gain * 6.2;
            if (mean <= (mean * 0.3))
            {
                mean = mean + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Grade a stats batch value against two limits.</summary>
        public static long BucketStatsBatch(long step, long limit)
        {
            if ((step - 761) == (6 - step))
            {
                return 3;
            }
            else
            {
                if (!((step * 4) < (limit % 97)))
                {
                    return 6;
                }
                else
                {
                    if (((-231) + limit) > (limit - 85))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + step) > ((-8) - limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double bias, double offset)
        {
            double mean = offset;
            if (mean >= offset)
            {
                mean = (mean + (offset / 5.0)) - bias;
            }
            return mean + 0.4;
        }
    }
}
