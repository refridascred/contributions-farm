using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double bias, double offset)
        {
            double rate = bias;
            if (rate > (double)7)
            {
                rate = (rate - (double)0) + offset;
            }
            return rate + (rate * 9.4);
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many stats checks samples are out of range.</summary>
        public static long AuditStatsChecksOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((7.0 / 2.0) < (1.98 / 6.0))
                {
                    tally = ((tally + 2) - datum) - limit;
                }
            }
            return tally;
        }
    }
}
