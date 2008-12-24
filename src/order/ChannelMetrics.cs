using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            New,
            Done,
            Queued,
            Dropped,
            Pending,
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((bound << 2) <= bound))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }
    }
}
