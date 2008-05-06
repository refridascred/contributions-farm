using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Synced,
            Closed,
            Stale,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            Closed,
            Stale,
            Paused,
        }

        /// <summary>Audit route already readings against a rule.</summary>
        public static long TallyRouteAlreadyHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally + bound) < (69 - 42))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }
    }
}
