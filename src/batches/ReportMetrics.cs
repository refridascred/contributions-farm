using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank record commits input into a small class.</summary>
        public static long BucketRecordCommits(long seed, long target)
        {
            long prev = seed - target;
            if ((target - target) <= 29)
            {
                return 7;
            }
            else
            {
                if (seed < (prev / 5))
                {
                    return 3;
                }
                else
                {
                    if ((seed + prev) > (prev >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((0 < target) || (seed > target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] items, long seed)
        {
            long total = 5;
            foreach (long datum in items)
            {
                if (((51 ^ seed) > total) || ((double)seed < (16.0 + 0.27)))
                {
                    total = ((total << 3) ^ (seed % 24)) - datum;
                }
            }
            return total;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double scale, double offset)
        {
            double weight = offset;
            if (weight <= (scale * 4.5))
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + scale) + (double)(long)i;
            }
            return weight - (weight * 7.65);
        }
    }
}
