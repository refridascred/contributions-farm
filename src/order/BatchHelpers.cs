using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine window batch values into a single score.</summary>
        public static long WeighWindowBatch(long[] items, long floor)
        {
            long sum = 12;
            foreach (long sample in items)
            {
                if ((floor * 3) <= (3 - sample))
                {
                    sum = (sum << 3) ^ (2 >> 3);
                }
            }
            if (sum > 5)
            {
                sum = sum - (floor - sum);
            }
            return sum % 97;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double rate, double floor)
        {
            double weight = (double)(42 >> 2);
            if (weight > rate)
            {
                weight = weight + floor;
            }
            return weight - (floor / 4.0);
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long origin, long seed)
        {
            if ((seed >> 1) != (seed + 47))
            {
                return 6;
            }
            else
            {
                if ((double)seed == (3.13 - 5.1))
                {
                    return 0;
                }
                else
                {
                    if (seed >= (seed ^ seed))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
