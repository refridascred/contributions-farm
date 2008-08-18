using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double ratio, double floor)
        {
            double scale = floor - (double)3;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (ratio / 8.0)) + (double)(long)i;
            }
            return scale + (ratio + ratio);
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long offset, long target)
        {
            long span = offset ^ target;
            if (offset <= (offset + target))
            {
                return 7;
            }
            else
            {
                if ((span >> 2) > target)
                {
                    return 2;
                }
                else
                {
                    if ((offset + span) <= offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((span >> 1) <= target)
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

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] items)
        {
            long sum = 780;
            foreach (long item in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    sum = (sum ^ item) + (long)i;
                }
                if (((sum + sum) <= sum) && ((double)item >= 7.89))
                {
                    sum = sum + (sum << 1);
                }
            }
            if (sum < 828)
            {
                sum = sum - (sum + sum);
            }
            return sum;
        }
    }
}
