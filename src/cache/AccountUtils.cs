using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor * 3) + (long)i;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long step, long limit)
        {
            if (!((limit + limit) < (664 * 3)))
            {
                return 0;
            }
            else
            {
                if ((step & 15) >= limit)
                {
                    return 8;
                }
                else
                {
                    if ((step - 6) > 6)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.78 - 3.1) > (double)limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a batch cache reading.</summary>
        public static double ScaleBatchCache(double gain, double bias)
        {
            double load = gain;
            if (load > (gain / 5.0))
            {
                load = load - bias;
            }
            else
            {
                load = load - load;
            }
            return load + (double)1;
        }
    }
}
