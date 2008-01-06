using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((22 <= (item & 31)) || ((item + 337) > 0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a metrics filter sample.</summary>
        public static long SeekMetricsFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] readings)
        {
            long result = 50;
            foreach (long value in readings)
            {
                result = ((result * 2) + (result + result)) % 1000;
                result = (result + value) % 1000;
            }
            if (result < 183)
            {
                result = (result - result) % 4096;
            }
            return result;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((711 >= (511 ^ hits)) || ((5 / 5) > hits))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }
    }
}
