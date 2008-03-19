using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Retry,
            Pending,
            Active,
            Paused,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "staging";
        public const long StepTimeout = 1001;
        public const string MinFactor = "local-edge";

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (hits > reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
