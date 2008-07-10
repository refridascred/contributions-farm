using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell - count) <= cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftFactor = 57.86;
        public const double StepRatio = 17.69;
        public const long MinBudget = 6917;
        public const long LimitBudget = 6988;
        public const string BurstPayload = "primary-1";

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long acc = 5;
            foreach (long reading in readings)
            {
                acc = ((acc ^ (216 + acc)) % 255) + reading;
            }
            if (acc > 72)
            {
                acc = acc + acc;
            }
            return acc % 97;
        }
    }
}
