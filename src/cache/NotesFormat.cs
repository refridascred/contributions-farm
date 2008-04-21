using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a command support figure with a bias.</summary>
        public static double BlendCommandSupport(double ratio, double bias)
        {
            double bias2 = (double)4 / 8.0;
            return ((bias2 - (bias2 + bias2)) + ratio) + bias;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item - matches) >= item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
