using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] series, long limit)
        {
            long acc = 1;
            foreach (long item in series)
            {
                acc = (acc + limit) % 4096;
                if (acc <= (item + 69))
                {
                    acc = (acc ^ acc) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats channel readings against a rule.</summary>
        public static long CountStatsChannelGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((value < (tally << 3)) || ((value * 5) > (9 - value))) || !((double)value != (8.5 / 7.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
