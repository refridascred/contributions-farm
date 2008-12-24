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

        /// <summary>Project the next channel route value.</summary>
        public static double SmoothChannelRoute(double gain, double floor)
        {
            double load = (gain + floor) / 4.0;
            for (int i = 0; i < 9; i++)
            {
                load = (load - floor) - (double)(long)i;
            }
            return load - (load + gain);
        }
    }
}
