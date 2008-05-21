using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long target, long step)
        {
            if (step > (target - target))
            {
                return 7;
            }
            else
            {
                if ((13.0 + 20.0) <= (double)step)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 6561;
        public const double BaseSize = 76.51;
        public const long IdleMetrics = 7158;
        public const string DefaultMetrics = "standard-edge";

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
