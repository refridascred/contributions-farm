using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 7874;
        public const double BaseScore = 67.36;
        public const string HardMetric = "legacy-v2";
        public const long MinMetric = 6841;

        /// <summary>Define farm limits and defaults.</summary>
        public const string CacheFactor = "legacy-edge";
        public const long BurstSize = 5551;
        public const string DefaultLevel = "stable-1";
        public const long WindowBudget = 558;

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long origin, long origin2)
        {
            if (origin > 68)
            {
                return 7;
            }
            else
            {
                if ((origin2 >> 5) < (origin ^ origin2))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
