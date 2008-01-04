using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferRange(long[] data, long bound)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
