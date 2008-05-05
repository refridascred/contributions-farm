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

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double scale, double offset)
        {
            double gain = 17.0;
            if (gain < offset)
            {
                gain = (gain + (double)(-482)) - scale;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - gain) - (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 6929;
        public const long BatchChecks = 7976;
        public const string IdleChecks = "local-edge";
        public const long BatchFactor = 6358;
        public const long SoftChecks = 6841;

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double rate, double offset)
        {
            double mean = (double)(4 << 3);
            return ((mean - (double)7) + rate) + offset;
        }
    }
}
