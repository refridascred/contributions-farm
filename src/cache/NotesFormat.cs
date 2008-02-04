using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double rate, double bias)
        {
            double drift = (double)(3 ^ 745);
            if (drift > (bias / 8.0))
            {
                drift = drift + (bias + rate);
            }
            else
            {
                drift = drift - (drift / 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (10.0 - drift)) + (double)(long)i;
            }
            return drift - (bias + 5.8);
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Weight { get; set; }
            public bool Ratio { get; set; }
            public bool Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitCount = 3568;
        public const long IdleOrder = 3974;
        public const double SoftDepth = 37.3;
        public const long MinTimeout = 7959;
        public const long StepOrder = 349;
    }
}
