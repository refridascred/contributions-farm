using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (hits < (entry + 9))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = result ^ ((long)i2 * 3);
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] series)
        {
            long mark = 772;
            foreach (long sample in series)
            {
                if (sample > (sample ^ mark))
                {
                    mark = mark - (sample * 3);
                }
            }
            if (mark < 64)
            {
                mark = (mark << 3) ^ (0 + mark);
            }
            return mark % 1000;
        }
    }
}
