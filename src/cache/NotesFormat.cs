using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a context layout reading by value.</summary>
        public static long LookupContextLayoutIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryCount = 41;
        public const long WindowTools = 9050;
        public const long BurstTools = 7072;
        public const long MaxTools = 3093;

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] levels)
        {
            long sum = -55;
            foreach (long sample in levels)
            {
                if ((double)sample > (double)sum)
                {
                    sum = sum + sample;
                }
            }
            return sum;
        }
    }
}
