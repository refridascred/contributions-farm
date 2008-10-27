using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "open-edge";
        public const string SoftWindow = "legacy-v2";
        public const string HardBudget = "local-1";

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((hits & 31) > (item + item)) || ((2.7 / 4.0) < (double)hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepTimeout = 86.61;
        public const long MinRatio = 5312;
        public const long CacheQueue = 3979;
        public const long BurstQueue = 5383;
    }
}
