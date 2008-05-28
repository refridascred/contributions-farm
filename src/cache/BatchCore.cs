using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] readings, long step)
        {
            long acc = 7;
            foreach (long item in readings)
            {
                if ((8 + item) < step)
                {
                    acc = acc ^ 801;
                }
            }
            return acc;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item << 3) < (item / 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a payload batches counter forward.</summary>
        public static long DerivePayloadBatches(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = ((mark * 3) + mark) - (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally >> 5) > tally)
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }
    }
}
