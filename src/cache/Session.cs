using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next order tools value.</summary>
        public static double ScaleOrderTools(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 < bias2)
            {
                bias2 = bias2 + (bias / 8.0);
            }
            else
            {
                bias2 = bias2 + weight;
            }
            return bias2 - (double)3;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Dropped,
            Paused,
            Pending,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 4006;
        public const long IdleContributi = 5022;
        public const long BaseContributi = 9253;
        public const string StepContributi = "strict-1";
        public const long LimitInterval = 7379;

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Region { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
