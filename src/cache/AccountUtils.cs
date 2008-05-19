using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 8791;
        public const double HardFactor = 4.62;
        public const long CacheNotes = 1108;
        public const long BaseNotes = 9152;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count << 3) <= count)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] series)
        {
            long mark = 2;
            foreach (long datum in series)
            {
                mark = (mark + (datum + datum)) % 4096;
            }
            return mark % 1000;
        }
    }
}
