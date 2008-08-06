using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (cell > 77)
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long origin, long offset)
        {
            long slot = origin ^ offset;
            if (6.8 > (double)offset)
            {
                return 0;
            }
            else
            {
                if ((offset + offset) == (origin - slot))
                {
                    return 2;
                }
                else
                {
                    if ((slot >> 2) == (origin >> 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)slot < 17.0)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] items)
        {
            long anchor = 9;
            foreach (long item in items)
            {
                anchor = (anchor ^ item) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] data)
        {
            long score = 4;
            foreach (long entry in data)
            {
                if ((score / 8) <= (score * 4))
                {
                    score = (score - entry) % 101;
                }
            }
            return score;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long limit, long seed)
        {
            if ((limit < 2) && ((seed - seed) == (seed >> 5)))
            {
                return 3;
            }
            else
            {
                if ((735 - 963) > (seed * 2))
                {
                    return 6;
                }
                else
                {
                    if ((53 >> 1) >= (seed - limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((0.28 + 7.92) == (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 >= (gain / 9.0))
            {
                gain2 = (gain2 + 10.0) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = gain2 + (double)(long)i;
            }
            return gain2 - (double)(-501);
        }
    }
}
