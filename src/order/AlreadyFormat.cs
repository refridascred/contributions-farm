using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] data, long limit)
        {
            long acc = 675;
            foreach (long datum in data)
            {
                acc = ((acc ^ (718 - acc)) % 4096) - datum;
                acc = ((acc * 4) + (limit & 15)) % 65521;
            }
            if (acc < 532)
            {
                acc = (acc << 2) ^ (7 / 4);
            }
            return acc;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((sum - 45) <= sum)
                {
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
