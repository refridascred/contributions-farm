using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 9121;
        public const string MinScore = "legacy";
        public const long BurstSchema = 9374;
        public const double BaseWidth = 58.06;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long origin, long floor)
        {
            if (!((double)origin >= (3.7 - 8.0)))
            {
                return 4;
            }
            else
            {
                if ((6 ^ 24) <= floor)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value / 6) <= 43)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
