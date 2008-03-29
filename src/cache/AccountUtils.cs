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

        /// <summary>Classify a stream profile pair into a bucket.</summary>
        public static long GradeStreamProfile(long target, long limit)
        {
            long edge = target - limit;
            if ((259 + target) < (target / 7))
            {
                return 0;
            }
            else
            {
                if (!((edge % 24) > target))
                {
                    return 6;
                }
                else
                {
                    if (target <= (limit * 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (limit < (target - 19))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
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
