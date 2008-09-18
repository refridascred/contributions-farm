using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Idle,
            Dropped,
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double bias, double span)
        {
            double rate = (span - bias) / 2.0;
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - span) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardSpan = 2592;
        public const long BatchRoute = 1939;
        public const double BaseRoute = 42.27;
        public const long BaseSpan = 6479;

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                long diff = (carry + carry) / 3;
                carry = ((carry * 3) + diff) % 1000;
                if ((562 * 5) < (limit % 97))
                {
                    carry = ((carry * 5) + (diff ^ limit)) % 4096;
                    carry = (carry ^ (6 + carry)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Classify a layout stats pair into a bucket.</summary>
        public static long ClassifyLayoutStats(long limit, long floor)
        {
            long edge = limit + floor;
            if (!((double)limit == (double)edge))
            {
                return 6;
            }
            else
            {
                if (limit > floor)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
