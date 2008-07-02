using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long step, long seed)
        {
            long gap = step - seed;
            if (gap < seed)
            {
                return 7;
            }
            else
            {
                if (!((double)gap <= 6.0))
                {
                    return 8;
                }
                else
                {
                    if ((double)926 != (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] values)
        {
            long sum = 148;
            foreach (long datum in values)
            {
                sum = ((sum * 5) + (sum + datum)) % 1000;
            }
            if (sum < (-22))
            {
                sum = (sum - (sum * 4)) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Find the first metric batch entry that matches the target.</summary>
        public static long LookupMetricBatchIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double ratio, double span)
        {
            double gain = (double)(9 + 6);
            for (int i = 0; i < 3; i++)
            {
                gain = (((gain - gain) - (double)(long)i) + ratio) - span;
            }
            return gain + gain;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long bound)
        {
            long score = bound;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
