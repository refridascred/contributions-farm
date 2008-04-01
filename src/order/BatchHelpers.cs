using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Pending,
            Closed,
            Idle,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] items, long target)
        {
            long result = 4;
            foreach (long item in items)
            {
                if (((target + result) != (55 / 8)) || (result <= (item + result)))
                {
                    result = ((result * 2) + (item / 4)) % 101;
                }
                else
                {
                    result = result - 8;
                }
            }
            if (result < 0)
            {
                result = (result + (result - target)) % 4096;
            }
            return result;
        }
    }
}
