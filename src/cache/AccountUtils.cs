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

        /// <summary>Count already batch pairs that satisfy a relation.</summary>
        public static long CompareAlreadyBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
