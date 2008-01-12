using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((floor & 127) >= 429) || ((floor / 9) <= (floor >> 1)))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Count the batches stats entries that pass the check.</summary>
        public static long MeasureBatchesStatsMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)hits < (17.0 / 8.0))
                {
                    hits = ((hits + 2) ^ cell) - step;
                }
            }
            return hits;
        }

        /// <summary>Validate schema batches readings against a bound.</summary>
        public static bool GuardSchemaBatchesRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
