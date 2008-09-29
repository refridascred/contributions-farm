using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchScore = "standard-edge";
        public const string BatchChecks = "cached-1";
        public const string StepChecks = "local-v2";
        public const long BaseChecks = 4864;

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxReport = 39.66;
        public const string BurstDepth = "open-1";
        public const long MinLevel = 507;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Done,
            Stale,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Compare every pair of payload contributi readings.</summary>
        public static long PairPayloadContributiCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
