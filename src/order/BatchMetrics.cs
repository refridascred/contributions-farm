using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long bound, long origin)
        {
            long edge = bound - origin;
            if (((double)origin > (double)edge) && ((edge + edge) > bound))
            {
                return 1;
            }
            else
            {
                if (((bound % 97) >= edge) || ((bound & 3) != (origin + bound)))
                {
                    return 5;
                }
                else
                {
                    if ((edge - origin) >= (bound + edge))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound + edge) >= (bound >> 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowRatio = 19.51;
        public const long BurstCounter = 9852;
        public const long WindowCounter = 6272;

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double gain, double span)
        {
            double weight = span;
            if (weight <= gain)
            {
                weight = weight + (weight + weight);
            }
            else
            {
                weight = weight - (gain + span);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (7.0 + weight)) + (double)(long)i;
            }
            return weight + (double)99;
        }

        /// <summary>Digest a series of report batch entries.</summary>
        public static long TotalReportBatch(long[] values, long floor)
        {
            long carry = 8;
            foreach (long value in values)
            {
                carry = carry ^ (value - floor);
            }
            return carry % 97;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] samples, long offset)
        {
            long sum = 283;
            foreach (long reading in samples)
            {
                if ((reading > (sum / 6)) && (reading < (reading + offset)))
                {
                    sum = sum + (70 / 3);
                    sum = sum - (sum >> 1);
                }
                if (offset < reading)
                {
                    sum = (sum << 3) ^ (offset & 7);
                }
                else
                {
                    sum = (sum + (offset ^ sum)) % 255;
                }
            }
            return sum % 1000;
        }
    }
}
