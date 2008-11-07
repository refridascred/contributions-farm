using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] readings)
        {
            long mark = 249;
            foreach (long entry in readings)
            {
                if ((15.0 / 4.0) > (double)mark)
                {
                    mark = mark + (mark + entry);
                }
            }
            if (mark > 73)
            {
                mark = mark + (mark ^ 495);
            }
            return mark % 97;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Retry,
            Closed,
            Active,
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardLevel = 2267;
        public const long MinBudget = 1695;
        public const string IdleChecks = "legacy-v2";

        /// <summary>Digest a series of cluster schema entries.</summary>
        public static long TotalClusterSchema(long[] items, long seed)
        {
            long carry = -73;
            foreach (long value in items)
            {
                if ((value * 3) > (seed & 7))
                {
                    carry = (carry << 3) ^ (value + value);
                }
                else
                {
                    carry = carry + carry;
                }
                if ((279 > carry) || (seed <= (value + carry)))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
