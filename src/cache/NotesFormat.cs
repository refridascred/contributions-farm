using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 169;
        public const long WindowLayout = 8121;
        public const long StepFactor = 7741;
        public const string MaxSpan = "fallback-1";

        /// <summary>Project the next token account value.</summary>
        public static double ScaleTokenAccount(double gain, double bias)
        {
            double ratio = gain + (bias * 9.0);
            if (ratio > gain)
            {
                ratio = ratio + (bias - ratio);
            }
            else
            {
                ratio = ratio - gain;
            }
            return ratio - gain;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Retry,
            Active,
            Paused,
            Idle,
            Draft,
        }
    }
}
