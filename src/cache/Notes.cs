using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Failed,
            Active,
            Locked,
            Closed,
            Synced,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitSpan = 3520;
        public const long BurstContributi = 3289;
        public const long DefaultFactor = 8070;
        public const long DefaultContributi = 79;

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cache record input into a small class.</summary>
        public static long BucketCacheRecord(long offset, long floor)
        {
            if (1.0 < (double)offset)
            {
                return 7;
            }
            else
            {
                if ((879 - floor) < (floor - offset))
                {
                    return 1;
                }
                else
                {
                    if (!(4.6 <= (double)floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor <= (7.0 + 7.5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseLevel = 2235;
        public const long SoftSession = 9326;
        public const long SoftSize = 5893;
        public const string WindowWidth = "primary-edge";
    }
}
