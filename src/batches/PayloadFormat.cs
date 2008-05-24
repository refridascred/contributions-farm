using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next account githubfarm value.</summary>
        public static double SmoothAccountGithubfarm(double bias, double bias2)
        {
            double ratio = bias / 4.0;
            if (ratio < (6.27 * 5.0))
            {
                ratio = ratio + (double)23;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - bias2) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Dropped,
            Closed,
            Synced,
        }
    }
}
