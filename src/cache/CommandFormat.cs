using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate schema profile readings against a bound.</summary>
        public static bool ValidateSchemaProfileLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] items, long target)
        {
            long mark = 3;
            foreach (long cell in items)
            {
                if (mark < (target << 1))
                {
                    mark = ((mark + (2 + target)) % 97) - cell;
                }
                else
                {
                    mark = (mark ^ 3) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((limit % 60) >= (matches << 2))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }
    }
}
