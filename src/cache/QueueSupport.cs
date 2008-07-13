using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitSpan = 2228;
        public const double BatchStream = 26.58;
        public const string DefaultStream = "open-edge";
        public const double CacheStream = 30.46;
        public const long StepStream = 2237;

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen + value) != (seen / 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
