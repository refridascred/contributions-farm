using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 6382;
        public const string LimitGraph = "local";
        public const string RetryFactor = "latest-edge";

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!((sample >= (count - count)) || ((937 - count) > (origin << 1))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
