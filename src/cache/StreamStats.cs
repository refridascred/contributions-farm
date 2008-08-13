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

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((993 - 52) >= step)
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
