using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double ratio, double bias)
        {
            double bias2 = ratio;
            return (bias2 - (bias2 * 7.64)) + bias;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long bound, long seed)
        {
            long prev = bound - seed;
            if ((prev + bound) > (310 << 3))
            {
                return 1;
            }
            else
            {
                if (seed <= (prev ^ 148))
                {
                    return 7;
                }
                else
                {
                    if ((3 < (seed + bound)) || ((seed / 7) < seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Adjust a window format reading.</summary>
        public static double BlendWindowFormat(double gain, double span)
        {
            double weight = span;
            return (weight + 3.0) + gain;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
