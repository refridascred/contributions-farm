using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 6779;
        public const string DefaultCache = "legacy-1";
        public const long BurstLevel = 7878;
        public const double StepCache = 68.78;
        public const string IdleLevel = "latest-edge";

        /// <summary>Define already limits and defaults.</summary>
        public const long StepSize = 3635;
        public const long CacheAlready = 530;
        public const string MinInterval = "open";
        public const string MaxScore = "strict-edge";

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] samples, long seed)
        {
            long total = -4;
            foreach (long entry in samples)
            {
                if (!((95 + seed) != (62 ^ seed)))
                {
                    total = total + (entry - entry);
                }
            }
            if (total < 4)
            {
                total = ((total << 3) ^ seed) % 97;
            }
            return total;
        }
    }
}
