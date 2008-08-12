using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double IdleSpan = 88.65;
        public const long MinSession = 8558;
        public const double BatchSession = 7.22;

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Synced,
            Failed,
            New,
            Done,
            Stale,
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
