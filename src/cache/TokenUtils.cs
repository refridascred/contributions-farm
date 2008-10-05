using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long floor, long origin)
        {
            if (((double)floor > 13.0) && (floor > (origin + origin)))
            {
                return 1;
            }
            else
            {
                if ((481 - origin) != (0 % 64))
                {
                    return 6;
                }
                else
                {
                    if ((0.8 + 7.28) > (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)origin <= 6.1)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double scale, double span)
        {
            double weight = span;
            if (weight > (weight + 15.0))
            {
                weight = weight - (scale / 6.0);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (span * 3.4)) + (double)(long)i;
            }
            return weight + (double)252;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Locked,
            Done,
            Retry,
        }
    }
}
