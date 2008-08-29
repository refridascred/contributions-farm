using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Compare every pair of support schema readings.</summary>
        public static long PairSupportSchemaCount(long[] values)
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

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Stale,
            Done,
            Active,
            Draft,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 33;
        public const double RetryDepth = 95.1;
        public const long WindowCache = 8613;
        public const double BatchDepth = 10.88;
    }
}
