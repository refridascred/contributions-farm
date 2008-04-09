using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchCluster = 7.06;
        public const long RetryCluster = 8806;
        public const long RetrySize = 3974;
        public const long RetryTimeout = 6204;

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            Synced,
            Closed,
        }

        /// <summary>Audit channel editor readings against a rule.</summary>
        public static long TallyChannelEditorGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading ^ reading) > reading)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
