using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double span)
        {
            double load = 8.58;
            for (int i = 0; i < 9; i++)
            {
                load = ((load - rate) - (double)(long)i) + span;
            }
            return load + 4.91;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Closed,
            Locked,
            Pending,
            Synced,
            Failed,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] readings)
        {
            long mark = -409;
            foreach (long cell in readings)
            {
                mark = (((mark * 4) + mark) % 1000) - cell;
            }
            if (mark > 9)
            {
                mark = (mark * 3) + ((long)readings.Length >> 1);
            }
            return mark;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
