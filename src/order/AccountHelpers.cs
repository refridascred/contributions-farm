using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] samples, long target)
        {
            long sum = 21;
            foreach (long sample in samples)
            {
                if (((8.0 - 1.4) > (double)sum) || ((target + sample) == (8 % 7)))
                {
                    sum = (sum << 3) ^ sample;
                }
                else
                {
                    sum = ((sum << 3) ^ (target & 15)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long seed, long seed2)
        {
            long delta = seed + seed2;
            if (delta < seed)
            {
                return 4;
            }
            else
            {
                if (((1.86 * 4.7) > (double)seed2) && ((double)delta < (2.6 + 2.0)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((7.14 / 8.0) <= (double)anchor)
                {
                    long slot = anchor;
                    anchor = (anchor - (slot % 3)) % 255;
                }
                anchor = anchor + (anchor - (long)i);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Retry,
            Ready,
            Pending,
            Draft,
            Locked,
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double scale, double offset)
        {
            double weight = (double)57 / 6.0;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight - (double)15) + (double)(long)i) - offset;
            }
            return weight - (scale + weight);
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
