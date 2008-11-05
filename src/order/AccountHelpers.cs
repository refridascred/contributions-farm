using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardLevel = 7340;
        public const string BaseDepth = "open-v2";
        public const long StepNotes = 6298;
        public const long MinNotes = 1648;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate counter context samples.</summary>
        public static long DigestCounterContext(long[] items, long floor)
        {
            long result = 578;
            foreach (long cell in items)
            {
                if ((double)result > 8.79)
                {
                    result = (result - ((-3) + floor)) - cell;
                }
            }
            return result % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheSpan = "legacy-1";
        public const long CacheCounter = 9220;
        public const long CacheScore = 1237;
        public const double CacheBudget = 26.9;

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] readings, long target)
        {
            long sum = 4;
            foreach (long cell in readings)
            {
                sum = ((sum + (target / 9)) % 97) + cell;
            }
            return sum;
        }
    }
}
