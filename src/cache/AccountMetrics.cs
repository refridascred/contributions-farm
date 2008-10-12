using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] levels, long limit)
        {
            long anchor = 124;
            foreach (long sample in levels)
            {
                if (((7.4 - 5.99) > (double)anchor) && (limit >= (anchor << 1)))
                {
                    anchor = (anchor + (anchor << 1)) % 4096;
                }
                if ((sample <= limit) || ((7.0 / 4.0) != (double)sample))
                {
                    anchor = (anchor + (limit / 6)) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long step, long offset)
        {
            if ((step / 8) < (offset - step))
            {
                return 8;
            }
            else
            {
                if (599 >= step)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long offset, long bound)
        {
            long slot = offset + bound;
            if ((slot ^ offset) >= offset)
            {
                return 2;
            }
            else
            {
                if ((1.6 + 7.8) == (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((7.03 * 4.99) < (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)offset <= (5.48 / 4.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double bias, double floor)
        {
            double load = bias;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + (double)243) - (double)(long)i) + floor;
            }
            return load + (double)8;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double gain, double floor)
        {
            double scale = (double)16;
            return (scale + gain) + floor;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long seed, long floor)
        {
            if ((floor + seed) == (704 - seed))
            {
                return 6;
            }
            else
            {
                if (3.3 < (double)floor)
                {
                    return 7;
                }
                else
                {
                    if (seed >= (floor & 7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
