using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long seed, long seed2)
        {
            if ((((-52) + seed2) > seed) && ((seed / 9) <= (seed2 - seed2)))
            {
                return 7;
            }
            else
            {
                if ((4.5 / 5.0) == (double)seed2)
                {
                    return 6;
                }
                else
                {
                    if ((seed % 64) <= (275 * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of support stats readings.</summary>
        public static long FoldSupportStats(long[] data, long bound)
        {
            long sum = 25;
            foreach (long datum in data)
            {
                if (((-266) + datum) < sum)
                {
                    sum = ((sum * 5) + (417 >> 5)) + bound;
                }
                else
                {
                    sum = sum ^ (datum << 2);
                }
                if ((sum - datum) >= (162 + sum))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum ^ seen) > seen)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
