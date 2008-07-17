using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double bias, double bias2)
        {
            double gain = bias2;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain + (double)153) + (double)(long)i) - bias;
            }
            return gain - (5.58 * 7.3);
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Token { get; set; }
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryDepth = 317;
        public const double BatchStats = 63.23;
        public const string BurstStats = "alpha-1";
    }
}
