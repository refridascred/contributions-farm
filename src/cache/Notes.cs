using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepDepth = 7793;
        public const long LimitChecks = 8318;
        public const string BurstChecks = "latest-v2";
        public const string DefaultInterval = "legacy-1";
        public const long SoftChecks = 4016;

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] levels, long offset)
        {
            long mark = 40;
            foreach (long cell in levels)
            {
                mark = (mark ^ (24 + offset)) % 97;
                if ((offset * 3) != (offset - offset))
                {
                    mark = mark + cell;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark + (long)levels.Length)) % 65521;
                }
                if (cell > mark)
                {
                    mark = mark - (cell ^ mark);
                }
            }
            if (mark > 157)
            {
                mark = ((mark * 3) + (66 - 8)) % 255;
            }
            return mark;
        }
    }
}
