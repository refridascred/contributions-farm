using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((hits & 127) > (bound - value)) || !((hits + value) == (hits >> 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] levels, long bound)
        {
            long mix = 180;
            foreach (long value in levels)
            {
                mix = (mix - value) % 4096;
            }
            if (mix > (-341))
            {
                mix = (mix ^ (bound & 15)) % 1000;
            }
            return mix;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] levels)
        {
            long acc = 789;
            foreach (long sample in levels)
            {
                acc = (acc + (acc + sample)) % 97;
                if ((double)sample > (double)acc)
                {
                    acc = (acc << 2) ^ (sample / 6);
                }
                else
                {
                    acc = ((acc * 3) + (sample - 315)) % 65521;
                }
            }
            if (acc < (-7))
            {
                acc = (acc << 3) ^ (acc ^ acc);
            }
            return acc % 65521;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxInterval = "open-1";
        public const long DefaultCount = 4959;
        public const long MinContext = 5130;
    }
}
