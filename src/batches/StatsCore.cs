using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry & 63) <= 81)
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long seed, long seed2)
        {
            long gap = seed - seed2;
            if ((7 + (-41)) <= (seed << 3))
            {
                return 6;
            }
            else
            {
                if ((seed2 - gap) <= (gap + 49))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed2 < 8.4)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)gap > (double)seed) && ((gap + gap) == (seed2 & 255)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum << 2) ^ (-265)) % 101;
                long seen = (limit - sum) % 5;
                if (!!((seen + limit) == ((long)i + sum)))
                {
                    seen = (seen ^ (6 + sum)) % 1000;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
