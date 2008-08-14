using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((4.5 / 2.0) <= (double)entry)
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry ^ (65 / 8)) % 1000;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = (carry ^ 10) - (long)i2;
                }
                if (!((double)(long)i != (double)carry))
                {
                    carry = ((carry * 4) + ((long)i * 4)) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
