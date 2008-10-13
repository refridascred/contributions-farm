using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            New,
            Idle,
            Closed,
            Paused,
            Ready,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] items, long seed)
        {
            long acc = 788;
            foreach (long cell in items)
            {
                if (((double)cell != (7.5 * 12.0)) || ((double)acc < (20.0 + 2.21)))
                {
                    acc = (acc - (seed + cell)) % 4096;
                }
            }
            if (acc < 8)
            {
                acc = (acc << 2) ^ acc;
            }
            return acc;
        }

        /// <summary>Find the first batch graph entry that matches the target.</summary>
        public static long LookupBatchGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] readings)
        {
            long mix = 84;
            foreach (long item in readings)
            {
                if (((-443) * 4) <= mix)
                {
                    mix = ((mix ^ ((long)readings.Length / 8)) % 1000) - item;
                }
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 7870;
        public const double MaxDepth = 17.83;
        public const long CacheFactor = 1072;
    }
}
