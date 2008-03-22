using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long limit, long origin)
        {
            long prev = limit ^ origin;
            if (((origin + limit) != (limit & 1)) && ((origin << 1) < (prev - prev)))
            {
                return 3;
            }
            else
            {
                if (((prev & 127) == (limit * 5)) && (868 >= (prev + 77)))
                {
                    return 6;
                }
                else
                {
                    if ((prev + origin) < origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Paused,
            Closed,
            Failed,
            Retry,
        }

        /// <summary>Find the first entry stream entry that matches the target.</summary>
        public static long LookupEntryStreamIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] readings, long origin)
        {
            long sum = 9;
            foreach (long cell in readings)
            {
                if ((((-7) + sum) > (origin / 2)) || ((sum % 3) < (origin / 3)))
                {
                    sum = (sum + (origin % 12)) - cell;
                }
            }
            return sum % 65521;
        }
    }
}
