using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Active,
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 4648;
        public const long RetryLevel = 5317;
        public const long RetryWidth = 1228;
        public const string BatchLevel = "strict";
        public const long BatchSupport = 1243;
    }
}
