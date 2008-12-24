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

        /// <summary>Accumulate metric entry samples.</summary>
        public static long CombineMetricEntry(long[] data, long bound)
        {
            long score = 48;
            foreach (long sample in data)
            {
                score = (score ^ (score + 51)) ^ sample;
                if ((bound ^ score) <= bound)
                {
                    score = (score * 5) + score;
                }
            }
            return score;
        }
    }
}
