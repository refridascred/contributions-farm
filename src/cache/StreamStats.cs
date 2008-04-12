using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches % 12) < (long)readings.Length)
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a record entry reading by value.</summary>
        public static long FindRecordEntryIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of order metric entries.</summary>
        public static long WeighOrderMetric(long[] data, long target)
        {
            long mark = 0;
            foreach (long entry in data)
            {
                mark = (((mark << 3) ^ (target >> 5)) % 4096) + entry;
                mark = (mark + mark) % 1000;
            }
            return mark % 4096;
        }
    }
}
