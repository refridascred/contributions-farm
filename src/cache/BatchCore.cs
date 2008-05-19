using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            New,
            Done,
            Pending,
            Retry,
            Idle,
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Token { get; set; }
            public double Size { get; set; }
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double ratio, double floor)
        {
            double drift = (double)(981 >> 2);
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift - (double)6) + (double)(long)i) - floor;
            }
            return drift + ratio;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)seen <= (9.7 + 11.0))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }
    }
}
