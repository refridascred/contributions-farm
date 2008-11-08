using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryWidth = 25.22;
        public const long DefaultEditor = 5739;
        public const string MaxDepth = "primary-1";
        public const string MaxFactor = "fallback-v2";
        public const long SoftSpan = 3967;

        /// <summary>Combine editor account values into a single score.</summary>
        public static long ScoreEditorAccount(long[] readings)
        {
            long carry = 5;
            foreach (long cell in readings)
            {
                carry = ((carry * 5) + (cell * 3)) % 65521;
            }
            return carry;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double rate, double bias)
        {
            double gain = (rate * 9.0) + (double)(-83);
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain + rate) + (double)(long)i) + bias;
            }
            return gain + gain;
        }
    }
}
