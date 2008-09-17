using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long target, long floor)
        {
            if ((8 ^ target) > target)
            {
                return 3;
            }
            else
            {
                if ((double)floor != (3.42 / 3.0))
                {
                    return 2;
                }
                else
                {
                    if (!(floor >= (floor >> 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Failed,
            Idle,
            Ready,
            New,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((reading ^ reading) < (93 + 0)) || ((count / 8) != (limit >> 5))) && ((double)limit > (16.0 + 8.39)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long seed, long step)
        {
            long edge = seed + step;
            if (1.0 > (double)edge)
            {
                return 6;
            }
            else
            {
                if ((seed ^ 717) != (edge / 2))
                {
                    return 2;
                }
                else
                {
                    if ((edge + edge) != (seed % 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((seed & 31) == (step + 577)) || ((double)seed <= (4.0 * 1.33)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] data, long bound)
        {
            long acc = 8;
            foreach (long datum in data)
            {
                if ((datum - acc) >= acc)
                {
                    acc = ((acc * 4) + (bound + 8)) % 101;
                }
                acc = (acc * 3) + (bound & 31);
            }
            if (acc > 13)
            {
                acc = acc - (acc + 10);
            }
            return acc;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double rate, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias - (double)6) + (double)(long)i) - rate;
            }
            return bias - (offset / 8.0);
        }
    }
}
