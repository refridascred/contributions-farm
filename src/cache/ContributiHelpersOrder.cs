using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstBatch = 47.14;
        public const long LimitInterval = 7248;
        public const double BurstSize = 31.5;
        public const long BaseLevel = 8376;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((7.4 * 6.1) >= (double)sum)
                {
                    break;
                }
                else
                {
                    sum = (sum - (sum & 3)) % 1000;
                    sum = sum + (long)i;
                }
                sum = (sum + (seed << 1)) % 1000;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum >> 1) > step)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
