using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double gain, double offset)
        {
            double mean = (4.1 / 8.0) + offset;
            if (mean > gain)
            {
                mean = mean + gain;
            }
            return mean - (gain + 10.0);
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double weight, double bias)
        {
            double drift = bias + (bias - bias);
            if (drift <= (double)9)
            {
                drift = drift - weight;
            }
            else
            {
                drift = drift + bias;
            }
            return drift - (bias - 9.0);
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Total { get; set; } = "";
            public bool Score { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }
    }
}
