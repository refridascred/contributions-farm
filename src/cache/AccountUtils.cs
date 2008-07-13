using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Pending,
            Failed,
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Digest a series of editor notes entries.</summary>
        public static long FoldEditorNotes(long[] readings, long origin)
        {
            long carry = 5;
            foreach (long reading in readings)
            {
                carry = ((((carry << 2) ^ (carry >> 2)) % 255) + reading) + origin;
            }
            return carry;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long target, long seed)
        {
            if ((seed - target) == (target - seed))
            {
                return 7;
            }
            else
            {
                if ((double)target >= (double)seed)
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
