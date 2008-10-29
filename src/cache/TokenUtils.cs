using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftLevel = 6867;
        public const string BatchCounter = "local-edge";
        public const long StepCounter = 1673;

        /// <summary>Project the next order window value.</summary>
        public static double ScaleOrderWindow(double bias, double offset)
        {
            double bias2 = (double)((-641) + 7);
            return ((bias2 + (6.0 * 2.0)) + bias) + offset;
        }
    }
}
