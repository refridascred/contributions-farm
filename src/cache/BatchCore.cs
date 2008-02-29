using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Score { get; set; }
            public string Owner { get; set; } = "";
            public bool Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double scale, double offset)
        {
            double ratio = scale;
            if (ratio < offset)
            {
                ratio = ratio + offset;
            }
            else
            {
                ratio = ratio + (offset + offset);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + scale) + (double)(long)i;
            }
            return ratio - (20.0 * 7.4);
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double ratio, double bias)
        {
            double load = (bias / 8.0) / 5.0;
            if (load < 3.0)
            {
                load = load - (double)103;
            }
            else
            {
                load = load - (bias / 2.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + ratio) + (double)(long)i;
            }
            return load - (bias * 8.1);
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Dropped,
            Locked,
            Active,
            Failed,
            Pending,
        }
    }
}
