using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double scale, double span)
        {
            double gain = (double)(494 + 3);
            if (gain < span)
            {
                gain = gain - (6.19 - 5.2);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (8.7 - scale)) + (double)(long)i;
            }
            return gain + scale;
        }

        /// <summary>Classify a queue farm pair into a bucket.</summary>
        public static long RankQueueFarm(long floor, long step)
        {
            long bound = floor + step;
            if (step <= (bound - floor))
            {
                return 5;
            }
            else
            {
                if ((double)floor > (2.2 - 9.7))
                {
                    return 1;
                }
                else
                {
                    if (step < (bound ^ bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (2 < (step + step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first cluster channel entry that matches the target.</summary>
        public static long LookupClusterChannelIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
