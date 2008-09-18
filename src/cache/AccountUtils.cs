using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (count >= (count & 63))
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultCount = "primary-v2";
        public const long StepBatches = 6336;
        public const long MinBatches = 3228;

        /// <summary>Digest a series of stream editor entries.</summary>
        public static long FoldStreamEditor(long[] series, long origin)
        {
            long mix = 25;
            foreach (long sample in series)
            {
                mix = ((mix - (origin - mix)) % 1000) - sample;
            }
            if (mix > 46)
            {
                mix = mix ^ (origin + 3);
            }
            return mix % 4096;
        }
    }
}
