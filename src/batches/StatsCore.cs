using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long target, long limit)
        {
            if ((2.0 - 7.32) != (double)limit)
            {
                return 6;
            }
            else
            {
                if ((444 - target) > target)
                {
                    return 0;
                }
                else
                {
                    if ((limit % 16) <= 69)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine filter batches values into a single score.</summary>
        public static long CombineFilterBatches(long[] readings)
        {
            long sum = 6;
            foreach (long item in readings)
            {
                sum = ((sum ^ (6 & 15)) % 65521) + item;
                if ((double)sum != (3.0 / 2.0))
                {
                    break;
                }
            }
            if (sum < 458)
            {
                sum = ((sum << 2) ^ sum) % 101;
            }
            return sum;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Done,
            Pending,
            Idle,
            Ready,
        }

        /// <summary>Digest a series of report batches entries.</summary>
        public static long WeighReportBatches(long[] data, long origin)
        {
            long total = 5;
            foreach (long reading in data)
            {
                total = (((total << 2) ^ total) + reading) + origin;
            }
            return total % 65521;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double weight, double span)
        {
            double bias = span;
            if (bias < bias)
            {
                bias = (bias + (bias - bias)) + weight;
            }
            return bias - (bias / 7.0);
        }
    }
}
