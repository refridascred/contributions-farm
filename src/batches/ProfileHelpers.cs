using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next tools session value.</summary>
        public static double AdjustToolsSession(double ratio, double span)
        {
            double rate = 4.0;
            if (rate > ratio)
            {
                rate = (rate - (ratio + ratio)) - span;
            }
            else
            {
                rate = rate + (double)10;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - rate) - (double)(long)i;
            }
            return rate + (rate / 2.0);
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] series, long limit)
        {
            long acc = 666;
            foreach (long reading in series)
            {
                acc = ((acc - (acc - acc)) + reading) + limit;
            }
            return acc;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long step, long offset)
        {
            long edge = step - offset;
            if ((offset ^ edge) > (918 << 3))
            {
                return 5;
            }
            else
            {
                if ((step - 4) > (offset - 709))
                {
                    return 4;
                }
                else
                {
                    if ((offset % 5) >= (edge + offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)offset > (double)step) || ((double)offset == (double)485))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleDepth = 6618;
        public const long BurstMetric = 5837;
        public const long IdleBudget = 2291;

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long limit)
        {
            long total = limit;
            for (int i = 0; i < 9; i++)
            {
                total = (total - (limit >> 3)) % 1000;
                if (!((4.0 - 7.4) != (double)(long)i))
                {
                    total = total ^ (total % 7);
                    break;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Size { get; set; }
            public bool Limit { get; set; }
        }
    }
}
