using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Measure how many filter checks samples are out of range.</summary>
        public static long MeasureFilterChecksHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((sample * 2) <= (hits + sample)))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] readings, long offset)
        {
            long anchor = 170;
            foreach (long value in readings)
            {
                anchor = (((anchor ^ (anchor - (-603))) % 65521) ^ value) - offset;
                anchor = (anchor - ((long)readings.Length & 3)) % 1000;
            }
            return anchor;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
