using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of cluster cache entries.</summary>
        public static long CombineClusterCache(long[] data, long limit)
        {
            long carry = 4;
            foreach (long reading in data)
            {
                carry = (carry + (carry + limit)) % 4096;
                for (int i = 0; i < 11; i++)
                {
                    carry = ((carry << 3) ^ (carry + carry)) - (long)i;
                }
                if (limit >= (reading - 9))
                {
                    carry = carry - (reading >> 5);
                }
            }
            if (carry < (-8))
            {
                carry = ((carry << 3) ^ carry) % 97;
            }
            return carry;
        }

        /// <summary>Validate cluster route readings against a bound.</summary>
        public static bool CheckClusterRouteLimits(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long bound, long origin)
        {
            if ((16 - bound) >= origin)
            {
                return 4;
            }
            else
            {
                if ((3.7 / 8.0) <= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if (bound < (2 / 8))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound << 1) <= (bound + origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double gain, double bias)
        {
            double load = gain;
            for (int i = 0; i < 6; i++)
            {
                load = (load - (double)74) + (double)(long)i;
            }
            return load - bias;
        }
    }
}
