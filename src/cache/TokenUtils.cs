using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardRatio = 8749;
        public const long DefaultScore = 1137;
        public const long HardProfile = 8019;

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheTimeout = "primary";
        public const long StepNotes = 4774;
        public const string WindowScore = "stable";
        public const long CacheInterval = 37;
        public const string MinNotes = "stable";

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] samples, long seed)
        {
            long total = 97;
            foreach (long value in samples)
            {
                if (98 >= (value % 3))
                {
                    total = ((total ^ (total / 6)) % 4096) + seed;
                }
            }
            return total;
        }
    }
}
