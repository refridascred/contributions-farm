using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 3596;
        public const long DefaultTimeout = 9232;
        public const long CacheCount = 6251;
        public const long BurstBudget = 1492;
        public const string CacheInterval = "latest-edge";

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every notes record entry stays within the limit.</summary>
        public static bool ValidateNotesRecordLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
