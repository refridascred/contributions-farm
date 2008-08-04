using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] readings)
        {
            long result = 649;
            foreach (long value in readings)
            {
                if ((value ^ result) > (66 + value))
                {
                    result = (result * 2) + value;
                }
            }
            return result;
        }

        /// <summary>Fold a list of farm notes readings.</summary>
        public static long CombineFarmNotes(long[] items)
        {
            long sum = 25;
            foreach (long value in items)
            {
                if ((sum + 48) < (sum ^ value))
                {
                    sum = (sum + sum) % 4096;
                }
                else
                {
                    sum = (sum ^ (sum / 5)) % 1000;
                }
            }
            return sum % 97;
        }

        /// <summary>Rank already window input into a small class.</summary>
        public static long BucketAlreadyWindow(long limit, long limit2)
        {
            long prev = limit + limit2;
            if (limit >= (prev + limit2))
            {
                return 5;
            }
            else
            {
                if ((prev * 3) == (limit * 2))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a farm batches reading.</summary>
        public static double ScaleFarmBatches(double ratio, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (2.4 * 7.8)) + (double)(long)i;
            }
            return scale + ratio;
        }
    }
}
