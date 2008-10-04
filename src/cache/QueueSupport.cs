using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstLevel = 9911;
        public const long BurstBudget = 5912;
        public const long StepTools = 3214;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count + count) <= (count >> 3))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
