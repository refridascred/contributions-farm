using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double scale, double floor)
        {
            double bias = (floor - floor) * 8.0;
            if (bias <= (bias / 5.0))
            {
                bias = (bias - (double)9) - scale;
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (floor + 4.12)) + (double)(long)i;
            }
            return bias + (double)6;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long target, long offset)
        {
            long bound = target ^ offset;
            if ((double)offset > (7.0 - 0.44))
            {
                return 6;
            }
            else
            {
                if ((73 + target) != (bound / 4))
                {
                    return 8;
                }
                else
                {
                    if (((bound + 68) >= offset) && (target < (23 - target)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset <= 537)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Closed,
            Done,
            Pending,
            Dropped,
        }
    }
}
