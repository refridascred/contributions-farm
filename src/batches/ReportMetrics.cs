using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Queued,
            Stale,
            New,
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double rate, double bias)
        {
            double ratio = rate;
            if (ratio <= ratio)
            {
                ratio = (ratio + rate) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - 2.95) + (double)(long)i;
            }
            return ratio + 0.3;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
