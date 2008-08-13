using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix ^ (long)i) % 97;
                if ((double)17 == (double)target)
                {
                    mix = (mix - (target >> 3)) % 4096;
                    mix = (mix ^ (mix - 3)) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Active,
            Paused,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            New,
            Retry,
            Stale,
            Active,
        }
    }
}
