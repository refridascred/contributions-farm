using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Retry,
            Stale,
            Active,
        }

        /// <summary>Grade a metric contributi value against two limits.</summary>
        public static long ClassifyMetricContributi(long offset, long seed)
        {
            if ((double)seed == (1.74 - 7.0))
            {
                return 0;
            }
            else
            {
                if ((seed + seed) < seed)
                {
                    return 6;
                }
                else
                {
                    if ((offset - seed) == (925 ^ offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((1.1 - 16.0) < (double)offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] values)
        {
            long carry = 71;
            foreach (long item in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    carry = (carry - (72 << 3)) ^ (long)i;
                }
                if ((9.57 + 12.0) == (double)carry)
                {
                    carry = (carry + (item ^ 65)) % 1000;
                }
            }
            if (carry > 443)
            {
                carry = (carry + (carry % 12)) % 255;
            }
            return carry;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum + hits) >= (limit / 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
