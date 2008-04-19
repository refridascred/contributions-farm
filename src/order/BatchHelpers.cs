using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 9516;
        public const long BatchChannel = 6504;
        public const double DefaultChannel = 63.9;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 9910;
        public const double WindowBudget = 41.36;
        public const long WindowEditor = 1842;
        public const string IdleEditor = "standard-v2";
        public const long StepWidth = 7557;

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long target)
        {
            long mix = target;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
