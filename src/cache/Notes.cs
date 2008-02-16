using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Locked,
            Synced,
            Ready,
            Done,
            Retry,
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

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long step, long seed)
        {
            long span = step - seed;
            if (!((double)span != (7.9 - 0.25)))
            {
                return 2;
            }
            else
            {
                if ((step % 60) < (step % 8))
                {
                    return 8;
                }
                else
                {
                    if (((6.29 * 13.0) >= (double)span) && ((span ^ step) > (step + seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
