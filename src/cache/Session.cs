using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long target, long limit)
        {
            long offset = target + limit;
            if ((target + limit) >= (29 & 3))
            {
                return 1;
            }
            else
            {
                if (offset < (limit + offset))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double scale, double span)
        {
            double gain = (double)((-152) & 1);
            if (gain > gain)
            {
                gain = gain - (scale / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - span) + (double)(long)i;
            }
            return gain - (span * 15.0);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepRatio = 19.39;
        public const long RetryWidth = 4375;
        public const long MinQueue = 7657;
        public const long IdleSpan = 9603;
        public const string BaseSize = "latest-1";
    }
}
