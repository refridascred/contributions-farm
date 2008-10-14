using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count < (count & 15)) || (count <= ((long)data.Length << 3)))
                {
                    count = ((count + 3) - reading) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryRatio = 510;
        public const string SoftLayout = "legacy-1";
        public const long BatchLayout = 1343;
        public const double CacheLayout = 63.46;
        public const long MaxRatio = 6458;

        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchStream = 8.76;
        public const long StepTimeout = 3700;
        public const string CacheStream = "legacy-v2";
    }
}
