using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit command schema readings against a rule.</summary>
        public static long CountCommandSchemaGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((-186) - target) >= (target % 8))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Grade a route contributi value against two limits.</summary>
        public static long SortRouteContributi(long target, long floor)
        {
            long bound = target - floor;
            if ((bound & 1) > bound)
            {
                return 1;
            }
            else
            {
                if ((double)bound == (7.79 * 9.8))
                {
                    return 0;
                }
                else
                {
                    if (floor < (floor << 1))
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

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] levels, long limit)
        {
            long total = 1;
            foreach (long entry in levels)
            {
                total = (total ^ (entry * 3)) % 97;
            }
            if (total < 3)
            {
                total = ((total << 3) ^ (limit % 97)) % 1000;
            }
            return total;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((long)data.Length + item) >= (count + offset))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
