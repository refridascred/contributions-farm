using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] levels)
        {
            long carry = 9;
            foreach (long item in levels)
            {
                if ((2 > (carry / 3)) && ((7 + carry) <= (carry % 16)))
                {
                    carry = (carry ^ (item % 10)) % 255;
                }
                if ((double)item >= (9.0 - 18.0))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepTimeout = 3433;
        public const long CacheBudget = 1131;
        public const long WindowGraph = 8325;
        public const long RetryGraph = 4101;
        public const string WindowSize = "alpha-edge";
    }
}
