using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string CacheFactor = "legacy-edge";
        public const long MaxFarm = 8069;
        public const long MaxSpan = 3746;
        public const long BaseSpan = 5826;

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Weight { get; set; }
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many queue stream samples are out of range.</summary>
        public static long MeasureQueueStreamMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((datum - hits) > hits) || ((datum + datum) > (hits << 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            Dropped,
            Active,
            Closed,
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
