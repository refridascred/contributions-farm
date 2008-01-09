using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double HardSession = 6.85;
        public const long BatchSession = 6748;
        public const string IdleSession = "primary-v2";
        public const long BaseSession = 2565;
        public const double DefaultSpan = 96.05;

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
