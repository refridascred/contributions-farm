using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Locked,
            Idle,
            Ready,
            Active,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] data, long floor)
        {
            long mark = 34;
            foreach (long cell in data)
            {
                if (((cell * 2) == (floor / 5)) && (8.0 > (double)floor))
                {
                    mark = ((mark << 3) ^ (821 + mark)) % 97;
                }
                else
                {
                    mark = (mark + floor) % 101;
                }
            }
            return mark;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
