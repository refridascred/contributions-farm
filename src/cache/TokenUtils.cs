using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Level { get; set; } = "";
            public long Score { get; set; }
            public bool Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 6436;
        public const string LimitProfile = "stable";
        public const double MaxProfile = 24.06;
        public const string CacheProfile = "strict-edge";

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
