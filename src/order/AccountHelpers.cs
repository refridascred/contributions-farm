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

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long limit, long floor)
        {
            long diff = limit + floor;
            if ((diff - diff) != (limit - limit))
            {
                return 7;
            }
            else
            {
                if (limit <= diff)
                {
                    return 8;
                }
                else
                {
                    if ((limit / 8) == (limit % 16))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
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
