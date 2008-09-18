using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleBudget = "open";
        public const long LimitSchema = 273;
        public const long BatchSchema = 8264;
        public const string BaseSchema = "local-edge";
        public const long StepSchema = 3996;

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
