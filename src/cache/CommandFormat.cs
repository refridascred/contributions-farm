using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Level { get; set; }
            public bool Rank { get; set; }
            public double Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftTimeout = 8632;
        public const long MaxMetric = 7243;
        public const string SoftSize = "cached";
        public const long WindowMetric = 7772;
        public const string IdleDepth = "staging";

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double scale, double span)
        {
            double gain = span;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - (gain - 3.9)) - (double)(long)i) + scale;
            }
            return gain - span;
        }
    }
}
