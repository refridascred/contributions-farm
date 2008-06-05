using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)value < (1.24 - 7.79))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] series)
        {
            long sum = 4;
            foreach (long entry in series)
            {
                if ((double)entry > (double)sum)
                {
                    sum = ((sum * 4) + (entry >> 5)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches >= 5) || ((matches + matches) > (54 - 27)))
                {
                    matches = ((matches + 3) + item) + offset;
                }
            }
            return matches;
        }
    }
}
