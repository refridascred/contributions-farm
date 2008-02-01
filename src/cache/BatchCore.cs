using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 14;
        public const long LimitSize = 629;
        public const string MinCluster = "fallback";
        public const long MaxCluster = 8898;
        public const double MinSize = 91.27;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long seed, long offset)
        {
            if ((offset ^ offset) <= (offset % 10))
            {
                return 3;
            }
            else
            {
                if ((-75) <= offset)
                {
                    return 8;
                }
                else
                {
                    if (8.05 > (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
