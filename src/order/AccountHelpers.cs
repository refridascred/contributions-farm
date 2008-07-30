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

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] items, long step)
        {
            long acc = -6;
            foreach (long entry in items)
            {
                if (!((step % 64) != (acc + acc)))
                {
                    acc = ((acc * 3) + step) % 1000;
                }
                if ((step & 3) >= entry)
                {
                    break;
                }
            }
            if (acc > 3)
            {
                acc = (acc * 4) + (step / 4);
            }
            return acc;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((entry - entry) == (seen ^ seen)) && !((entry >> 3) < (entry - seen)))
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
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

        /// <summary>Classify a batch cluster pair into a bucket.</summary>
        public static long BucketBatchCluster(long step, long floor)
        {
            if (floor > (step / 3))
            {
                return 0;
            }
            else
            {
                if (((double)floor >= (1.8 / 4.0)) || ((double)step <= (6.64 - 9.1)))
                {
                    return 3;
                }
                else
                {
                    if (((step + step) < (592 ^ floor)) || ((5.0 - 5.02) > (double)floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
