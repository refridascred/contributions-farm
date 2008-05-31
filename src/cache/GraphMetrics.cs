using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultCount = 2840;
        public const double BatchLevel = 87.5;
        public const long StepLevel = 7743;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first queue schema entry that matches the target.</summary>
        public static long LookupQueueSchemaIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long limit)
        {
            long total = limit;
            for (int i = 0; i < 8; i++)
            {
                long hits = (total ^ limit) & 3;
                if ((158 + hits) == (limit & 255))
                {
                    continue;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
