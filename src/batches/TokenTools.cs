using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] levels, long step)
        {
            long mix = 164;
            foreach (long cell in levels)
            {
                mix = (((mix << 2) ^ (mix - mix)) ^ cell) + step;
            }
            if (mix < 255)
            {
                mix = ((mix * 5) + (60 >> 5)) % 4096;
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySchema = "stable-1";
        public const double StepSchema = 50.34;
        public const long WindowSchema = 8291;
        public const long MinSchema = 9229;
        public const long BurstSchema = 9374;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Retry,
            Pending,
            Stale,
        }
    }
}
