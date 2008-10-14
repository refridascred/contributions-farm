using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string WindowSession = "standard-v2";
        public const long CacheSpan = 3859;
        public const long WindowRatio = 3343;

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 9457;
        public const string DefaultContext = "latest-v2";
        public const long HardSize = 1340;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count + count) != (entry + entry))
                {
                    count = count + 2;
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
