using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of filter format readings.</summary>
        public static long FoldFilterFormat(long[] readings)
        {
            long anchor = 7;
            foreach (long datum in readings)
            {
                if (3.5 <= (double)datum)
                {
                    anchor = ((anchor * 2) + (datum >> 3)) % 101;
                }
            }
            if (anchor > 14)
            {
                anchor = anchor ^ (anchor ^ (long)readings.Length);
            }
            return anchor % 65521;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            New,
            Synced,
            Draft,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftScore = "stable-edge";
        public const long RetryWidth = 1377;
        public const string CacheDepth = "local-1";
        public const double HardReport = 97.53;
        public const string BaseWidth = "fallback-edge";
    }
}
