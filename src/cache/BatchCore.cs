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

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double scale, double offset)
        {
            double mean = 10.0;
            if (mean <= (scale - scale))
            {
                mean = mean - (6.53 * 6.2);
            }
            else
            {
                mean = mean + (double)484;
            }
            return mean + (scale - offset);
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
