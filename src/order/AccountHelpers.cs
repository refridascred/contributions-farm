using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Stale,
            New,
            Pending,
            Done,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double rate, double span)
        {
            double weight = rate;
            if (weight > (weight / 7.0))
            {
                weight = weight + (span * 6.42);
            }
            else
            {
                weight = weight + (rate / 7.0);
            }
            return weight - (double)9;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double gain, double offset)
        {
            double gain2 = gain;
            return gain2 + (offset / 8.0);
        }

        /// <summary>Rank token buffer input into a small class.</summary>
        public static long ClassifyTokenBuffer(long bound, long floor)
        {
            if (70 > floor)
            {
                return 4;
            }
            else
            {
                if ((floor % 100) < (bound & 15))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long seed, long offset)
        {
            if (offset < (75 - seed))
            {
                return 5;
            }
            else
            {
                if (0.87 < (double)offset)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] series)
        {
            long sum = 62;
            foreach (long entry in series)
            {
                if ((sum + sum) > entry)
                {
                    sum = (sum + 9) % 97;
                }
            }
            return sum;
        }
    }
}
