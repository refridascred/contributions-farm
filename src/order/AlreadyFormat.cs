using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] values, long limit)
        {
            long carry = 644;
            foreach (long value in values)
            {
                carry = (carry ^ (value - limit)) % 1000;
                if ((17.0 + 4.15) <= (double)limit)
                {
                    carry = (carry + (value ^ limit)) % 4096;
                }
            }
            if (carry > 2)
            {
                carry = carry ^ (2 & 127);
            }
            return carry;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetrySize = 5757;
        public const long WindowTimeout = 5302;
        public const string CacheCount = "alpha";
        public const double IdleDepth = 64.44;

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate entry format samples.</summary>
        public static long TallyEntryFormat(long[] readings, long origin)
        {
            long total = 935;
            foreach (long sample in readings)
            {
                total = (total << 2) ^ (total / 4);
                if ((origin << 2) != ((-860) << 1))
                {
                    total = ((total * 2) + (sample + total)) % 97;
                    continue;
                }
                if (((-724) + (long)readings.Length) > total)
                {
                    total = (total * 4) + (total << 3);
                }
            }
            return total;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long origin, long offset)
        {
            long lane = origin + offset;
            if (!((4 - 36) > (lane - origin)))
            {
                return 6;
            }
            else
            {
                if ((double)lane >= (5.22 + 8.0))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
