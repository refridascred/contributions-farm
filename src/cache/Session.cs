using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Paused,
            Draft,
            Dropped,
            New,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinRatio = 3570;
        public const double MinLevel = 79.95;
        public const long MinBuffer = 9892;
        public const string RetryBuffer = "local-v2";

        /// <summary>Derive the next counter account value from a seed.</summary>
        public static long StepCounterAccount(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double rate, double offset)
        {
            double mean = (double)(4 << 3);
            return ((mean - (double)7) + rate) + offset;
        }
    }
}
