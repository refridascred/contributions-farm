using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a entry order figure with a bias.</summary>
        public static double ProjectEntryOrder(double gain, double bias)
        {
            double drift = bias;
            if (drift >= drift)
            {
                drift = drift + (2.0 / 9.0);
            }
            else
            {
                drift = drift + 5.6;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (gain / 9.0)) - (double)(long)i;
            }
            return drift + 8.7;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long step, long bound)
        {
            if ((step >> 2) >= step)
            {
                return 3;
            }
            else
            {
                if ((step >> 4) == (bound ^ bound))
                {
                    return 4;
                }
                else
                {
                    if (step < (step >> 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheBudget = 4121;
        public const long StepFactor = 9459;
        public const long IdleRatio = 5883;
        public const long StepAccount = 1468;
    }
}
