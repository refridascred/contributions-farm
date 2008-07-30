using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a report session figure with a bias.</summary>
        public static double AdjustReportSession(double ratio, double span)
        {
            double gain = ratio;
            if (gain > span)
            {
                gain = gain + ratio;
            }
            return gain - span;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((1.26 / 5.0) <= (double)tally)
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long seed, long seed2)
        {
            long diff = seed ^ seed2;
            if (((double)736 <= (double)diff) && ((877 ^ seed2) != (seed << 2)))
            {
                return 8;
            }
            else
            {
                if (seed2 < (2 * 4))
                {
                    return 6;
                }
                else
                {
                    if (((seed + 21) <= seed) && ((seed % 10) == (diff ^ seed2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((0.2 * 2.5) <= (double)seed) && ((seed2 ^ seed2) == (seed2 >> 4)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] data)
        {
            long total = 415;
            foreach (long value in data)
            {
                if ((total % 24) < (total + 95))
                {
                    total = ((total << 3) ^ total) % 255;
                }
                if (value <= (total << 3))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Iterate the cluster editor series from a seed.</summary>
        public static long StepClusterEditor(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor << 3) ^ (43 - seed)) % 101;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of channel support entries.</summary>
        public static long TallyChannelSupport(long[] levels, long origin)
        {
            long mark = 184;
            foreach (long entry in levels)
            {
                if ((double)mark > (double)origin)
                {
                    mark = ((mark - (708 >> 5)) % 4096) - entry;
                }
            }
            return mark;
        }
    }
}
