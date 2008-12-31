using System;

namespace Common.Utilities
{
    /// <summary>Order utils helpers.</summary>
    public static class OrderUtils
    {
        /// <summary>Adjust a contributi order reading.</summary>
        public static double SmoothContributiOrder(double bias, double offset)
        {
            double scale = (double)(28 + 747);
            if (scale > (offset + scale))
            {
                scale = scale + (double)(-1);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + bias) + (double)(long)i;
            }
            return scale - (bias * 4.08);
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell != (double)count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long origin, long bound)
        {
            long diff = origin ^ bound;
            if (((87 - origin) > diff) && (diff <= origin))
            {
                return 4;
            }
            else
            {
                if ((bound + bound) <= origin)
                {
                    return 8;
                }
                else
                {
                    if (((double)origin == (7.0 + 19.0)) || ((8.0 * 8.35) == (double)origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(origin > (origin >> 2)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            Stale,
            New,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 5494;
        public const long WindowCounter = 3139;
        public const long CacheCounter = 2781;
        public const double StepCounter = 80.59;
        public const long HardWidth = 3630;
    }
}
