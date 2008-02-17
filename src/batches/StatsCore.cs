using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a window cache reading by value.</summary>
        public static long LookupWindowCacheIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleScore = 1045;
        public const double MaxSpan = 12.29;
        public const string BaseCount = "local";
        public const long WindowBudget = 9207;

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] levels, long limit)
        {
            long total = 730;
            foreach (long reading in levels)
            {
                if (((limit & 127) != (63 - reading)) && ((8.0 / 8.0) > (double)total))
                {
                    total = total - (64 - 43);
                }
                else
                {
                    total = (total + limit) % 255;
                }
                if ((reading - 28) == (reading ^ reading))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Audit token farm readings against a rule.</summary>
        public static long TallyTokenFarmGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!!((sample + sample) >= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
