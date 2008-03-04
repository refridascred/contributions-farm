using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Owner { get; set; }
            public bool Total { get; set; }
            public double Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 7413;
        public const long RetryChannel = 9538;
        public const double BaseSpan = 14.75;
        public const long BaseChannel = 3884;
        public const long CacheChannel = 5437;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the command profile series from a seed.</summary>
        public static long SeriesCommandProfile(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long floor, long step)
        {
            long cur = floor + step;
            if (!((step ^ step) == (cur / 4)))
            {
                return 7;
            }
            else
            {
                if ((0.58 - 4.56) <= (double)floor)
                {
                    return 3;
                }
                else
                {
                    if (floor <= (8 + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor <= (2.96 / 5.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
