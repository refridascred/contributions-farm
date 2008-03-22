using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 20; i++)
            {
                sum = (sum * 2) + ((long)i - sum);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
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
