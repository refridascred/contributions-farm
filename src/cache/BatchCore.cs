using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double ratio, double span)
        {
            double mean = span;
            if (mean < (4.08 - ratio))
            {
                mean = mean - 1.94;
            }
            return mean + (mean + 11.0);
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Rank { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Dropped,
            Queued,
            Stale,
        }
    }
}
