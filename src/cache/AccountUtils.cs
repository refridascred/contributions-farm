using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a farm cluster pair into a bucket.</summary>
        public static long GradeFarmCluster(long bound, long limit)
        {
            long span = bound + limit;
            if ((7.01 / 5.0) == (double)span)
            {
                return 0;
            }
            else
            {
                if (bound >= (limit % 24))
                {
                    return 5;
                }
                else
                {
                    if (((limit + limit) < (bound + bound)) || ((limit + limit) == (bound + bound)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 9597;
        public const long MinWidth = 3725;
        public const long SoftEntry = 9489;
        public const string HardWidth = "stable";

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitInterval = "stable-v2";
        public const double RetryEditor = 83.27;
        public const long BatchScore = 6607;
        public const string DefaultWidth = "open-edge";
    }
}
