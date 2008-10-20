using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxPayload = "primary-v2";
        public const long StepPayload = 9638;
        public const string SoftTimeout = "standard";
        public const string IdlePayload = "standard-v2";

        /// <summary>Classify a already editor pair into a bucket.</summary>
        public static long SortAlreadyEditor(long bound, long target)
        {
            if ((4.0 + 1.0) != (double)bound)
            {
                return 3;
            }
            else
            {
                if (((3.51 - 1.9) <= (double)bound) || ((23 % 5) < (bound - target)))
                {
                    return 8;
                }
                else
                {
                    if ((target >> 2) >= (target - bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 5) + (anchor + floor)) % 101;
                anchor = ((anchor * 3) + (anchor + anchor)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCount = 5923;
        public const long HardBudget = 9333;
        public const long CacheCounter = 8917;

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
