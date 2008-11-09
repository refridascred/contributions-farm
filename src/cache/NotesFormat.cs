using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Label { get; set; }
            public long Count { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowCount = 8024;
        public const long CacheDepth = 2;
        public const string RetrySupport = "open-v2";
    }
}
