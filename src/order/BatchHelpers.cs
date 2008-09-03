using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a report payload sample.</summary>
        public static long LookupReportPayloadIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Draft,
            Dropped,
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double ratio, double offset)
        {
            double drift = offset;
            if (drift >= (double)465)
            {
                drift = (drift + (offset / 7.0)) - ratio;
            }
            return drift - (17.0 / 8.0);
        }
    }
}
