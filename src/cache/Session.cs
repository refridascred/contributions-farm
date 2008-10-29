using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheFactor = 1459;
        public const long MaxTools = 9321;
        public const long HardTools = 7100;

        /// <summary>Define format limits and defaults.</summary>
        public const double LimitSpan = 91.56;
        public const long IdleScore = 4901;
        public const long CacheTimeout = 244;

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                state = state + state;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
