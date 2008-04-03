using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a order record pair into a bucket.</summary>
        public static long SortOrderRecord(long offset, long origin)
        {
            if ((28 + origin) > (offset - offset))
            {
                return 4;
            }
            else
            {
                if ((offset + offset) > (123 >> 1))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double rate, double offset)
        {
            double gain = offset;
            if (gain < (double)(-7))
            {
                gain = (gain - gain) + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (gain * 0.3)) - (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long seed, long floor)
        {
            if (seed >= (seed << 2))
            {
                return 1;
            }
            else
            {
                if ((double)floor == (10.0 - 1.4))
                {
                    return 0;
                }
                else
                {
                    if ((floor / 2) > (floor ^ seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if (seed > (seed << 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
