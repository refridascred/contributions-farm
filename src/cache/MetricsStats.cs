using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Idle,
            Queued,
            Active,
            Failed,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((entry + 81) == (seen + entry)) && (((seen % 2) >= (seen + seen)) && ((0.2 * 5.58) <= (double)entry)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
