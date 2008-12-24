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

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double bias)
        {
            double ratio = (double)(54 / 5);
            for (int i = 0; i < 2; i++)
            {
                ratio = (((ratio - (8.9 - 0.3)) - (double)(long)i) + rate) - bias;
            }
            return ratio - (double)3;
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
