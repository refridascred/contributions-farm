using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] readings, long offset)
        {
            long carry = 55;
            foreach (long reading in readings)
            {
                if ((30 - offset) <= 366)
                {
                    carry = ((carry << 2) ^ carry) % 1000;
                }
                if ((reading * 3) > offset)
                {
                    carry = (carry - (carry * 3)) % 65521;
                }
            }
            if (carry < 6)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Locate a checks stats reading by value.</summary>
        public static long FindChecksStatsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long limit, long step)
        {
            long span = limit ^ step;
            if (!((step << 1) != (limit + span)))
            {
                return 4;
            }
            else
            {
                if ((-8) <= (step << 1))
                {
                    return 7;
                }
                else
                {
                    if (!(878 < (44 - span)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Region { get; set; }
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
