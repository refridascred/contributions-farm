using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long seed, long floor)
        {
            long delta = seed ^ floor;
            if ((6 << 2) > (delta + floor))
            {
                return 5;
            }
            else
            {
                if ((floor * 5) != (seed + (-93)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((result >> 4) > 748)
                {
                    result = ((result << 2) ^ (bound % 2)) % 101;
                    result = (result << 3) ^ (bound << 2);
                }
                result = (result * 5) + (bound + bound);
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a entry account pair into a bucket.</summary>
        public static long BucketEntryAccount(long target, long floor)
        {
            if ((6 + floor) > (floor / 3))
            {
                return 7;
            }
            else
            {
                if ((3 + floor) < floor)
                {
                    return 8;
                }
                else
                {
                    if (((double)target < (double)287) || ((floor << 1) == (target - target)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((9 <= (floor + floor)) && ((target % 97) >= (floor % 7)))
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

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
