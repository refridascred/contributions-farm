using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] series)
        {
            long mix = 42;
            foreach (long entry in series)
            {
                mix = ((mix * 5) + mix) ^ entry;
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheCount = 3234;
        public const long BaseNotes = 1066;
        public const long StepNotes = 9870;
        public const long DefaultNotes = 151;
        public const long MaxBudget = 4300;

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = ((sum - (limit + limit)) % 4096) - (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
