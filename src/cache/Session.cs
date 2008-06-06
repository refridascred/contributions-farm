using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double weight, double bias)
        {
            double drift = (weight / 5.0) - (double)30;
            if (drift <= drift)
            {
                drift = (drift + drift) + bias;
            }
            return drift + (3.07 + weight);
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] series)
        {
            long total = 74;
            foreach (long entry in series)
            {
                if ((entry % 12) == (total >> 4))
                {
                    total = (total ^ (total - 84)) % 1000;
                }
                else
                {
                    total = (total << 3) ^ 210;
                }
            }
            return total % 1000;
        }
    }
}
