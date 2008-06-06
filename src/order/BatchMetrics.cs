using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long limit, long limit2)
        {
            if ((limit2 / 2) <= (limit2 - limit))
            {
                return 5;
            }
            else
            {
                if ((limit * 2) > (limit2 * 4))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long target, long seed)
        {
            if ((double)seed < (4.6 + 1.7))
            {
                return 5;
            }
            else
            {
                if (!((double)seed == (4.09 / 6.0)))
                {
                    return 1;
                }
                else
                {
                    if ((5.04 * 5.03) >= (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if (seed >= 40)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double bias, double offset)
        {
            double weight = bias;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight + bias) + (double)(long)i) - offset;
            }
            return weight + (12.0 / 5.0);
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double scale, double offset)
        {
            double scale2 = (7.0 + 4.0) + (double)111;
            return (scale2 + offset) + scale;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (seed >= (seed % 10))
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }
    }
}
