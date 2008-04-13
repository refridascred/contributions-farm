using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long floor, long target)
        {
            if ((12.0 + 16.0) > (double)target)
            {
                return 3;
            }
            else
            {
                if ((target & 31) > (target + target))
                {
                    return 4;
                }
                else
                {
                    if ((target >> 1) >= (3 << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((8 + floor) != (target - floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((300 << 2) == (32 - value))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
