using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate schema cache samples.</summary>
        public static long WeighSchemaCache(long[] levels, long target)
        {
            long mark = 5;
            foreach (long datum in levels)
            {
                if ((3.91 - 17.0) != (double)target)
                {
                    mark = (mark ^ (mark >> 4)) ^ datum;
                }
                if (((-9) ^ 1) < (target << 2))
                {
                    mark = mark ^ (target & 1);
                }
            }
            if (mark < 67)
            {
                mark = (mark - 65) % 255;
            }
            return mark;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Mode { get; set; }
            public double Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value & 1) > origin)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stats profile sample.</summary>
        public static long LookupStatsProfileIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
