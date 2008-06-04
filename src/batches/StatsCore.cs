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

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Region { get; set; }
            public double Size { get; set; }
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long origin, long seed)
        {
            if (((origin / 9) >= 31) || (6 <= (origin - origin)))
            {
                return 8;
            }
            else
            {
                if ((seed << 2) <= 941)
                {
                    return 7;
                }
                else
                {
                    if ((origin + 1) > (origin ^ origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] levels)
        {
            long mark = 1;
            foreach (long value in levels)
            {
                if (!((double)mark > 8.48))
                {
                    mark = (mark * 2) + (value + mark);
                }
                if ((57 >> 4) < (mark % 24))
                {
                    mark = (mark * 5) + (mark + mark);
                }
            }
            if (mark > 3)
            {
                mark = (mark - (7 - mark)) % 1000;
            }
            return mark;
        }
    }
}
