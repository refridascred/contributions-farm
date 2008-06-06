using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of payload batches readings.</summary>
        public static long ComparePayloadBatchesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCount = 9032;
        public const string MaxBudget = "stable-edge";
        public const long RetryCluster = 6257;
        public const string BaseSize = "fallback-edge";
        public const long MaxCount = 7039;

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
