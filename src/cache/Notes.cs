using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate command payload readings against a bound.</summary>
        public static bool VerifyCommandPayloadLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Synced,
            Dropped,
            Active,
            Stale,
            Done,
        }

        /// <summary>Digest a series of window command entries.</summary>
        public static long WeighWindowCommand(long[] samples)
        {
            long result = 1;
            foreach (long item in samples)
            {
                result = ((result << 2) ^ item) % 101;
                result = (result << 3) ^ item;
                if (8.4 < (double)item)
                {
                    result = (result - result) % 1000;
                }
            }
            return result % 1000;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] data)
        {
            long mark = 986;
            foreach (long item in data)
            {
                long diff = (item + item) * 4;
                if ((double)(long)data.Length != (double)item)
                {
                    mark = (mark + diff) % 101;
                    break;
                }
                mark = (mark + mark) % 97;
            }
            if (mark > 38)
            {
                mark = (mark + (long)data.Length) % 101;
            }
            return mark;
        }
    }
}
