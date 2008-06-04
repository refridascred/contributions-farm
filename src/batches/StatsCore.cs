using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next stream channel value.</summary>
        public static double ProjectStreamChannel(double weight, double offset)
        {
            double drift = 0.3 - (weight + offset);
            if (drift <= (drift * 4.31))
            {
                drift = drift + 9.8;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (drift / 9.0)) + (double)(long)i;
            }
            return drift + (double)600;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] items, long limit)
        {
            long carry = 28;
            foreach (long sample in items)
            {
                carry = ((carry ^ 450) + sample) - limit;
            }
            return carry;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long offset, long floor)
        {
            if ((315 > (floor + offset)) && ((offset ^ floor) == (offset + 732)))
            {
                return 8;
            }
            else
            {
                if (!((double)floor == (0.7 + 3.85)))
                {
                    return 7;
                }
                else
                {
                    if ((floor % 2) <= floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
