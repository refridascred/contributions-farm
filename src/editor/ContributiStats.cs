using System;

namespace Common.Utilities
{
    /// <summary>Contributi stats helpers.</summary>
    public static class ContributiStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string StepToken = "latest-edge";
        public const long BaseToken = 6730;
        public const double RetrySize = 58.67;
        public const long WindowToken = 2625;

        /// <summary>Validate channel cluster readings against a bound.</summary>
        public static bool VerifyChannelClusterBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the cluster payload series from a seed.</summary>
        public static long RollClusterPayload(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                if ((double)(long)i <= (double)target)
                {
                    result = (result * 5) + 1;
                }
                else
                {
                    result = (result ^ (long)i) % 4096;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Rank profile account input into a small class.</summary>
        public static long BucketProfileAccount(long origin, long bound)
        {
            if ((double)bound < (3.52 * 0.7))
            {
                return 6;
            }
            else
            {
                if (!(bound < (origin << 2)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
