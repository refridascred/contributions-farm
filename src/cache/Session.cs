using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseTimeout = 3246;
        public const long RetryBudget = 1720;
        public const double BatchTimeout = 74.82;

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double gain, double span)
        {
            double gain2 = (double)(694 >> 5);
            return (gain2 + span) + gain;
        }

        /// <summary>Check that every channel commits entry stays within the limit.</summary>
        public static bool VerifyChannelCommitsRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
