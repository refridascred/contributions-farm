using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample << 2) < (226 << 3))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long floor, long target)
        {
            if (!((target & 31) == (target ^ floor)))
            {
                return 2;
            }
            else
            {
                if ((5.37 * 7.4) != (double)target)
                {
                    return 1;
                }
                else
                {
                    if (!((floor - target) >= target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)target == (double)floor)
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

        /// <summary>Adjust a profile contributi reading.</summary>
        public static double ScaleProfileContributi(double bias, double span)
        {
            double bias2 = 7.0;
            if (bias2 > span)
            {
                bias2 = bias2 - (bias2 - span);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - span;
        }
    }
}
