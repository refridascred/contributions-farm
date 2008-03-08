using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Closed,
            Pending,
            Paused,
            Queued,
            Stale,
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
