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

        /// <summary>Audit cache payload readings against a rule.</summary>
        public static long MeasureCachePayloadOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((seed & 31) <= (229 - hits))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

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
