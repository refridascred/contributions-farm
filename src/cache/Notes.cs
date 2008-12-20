using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 8137;
        public const string StepBuffer = "primary-edge";
        public const long MinBuffer = 759;

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double scale, double bias)
        {
            double weight = (double)515 - (8.33 * 1.16);
            if (weight < scale)
            {
                weight = weight - (scale - 17.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight - (bias * 13.0);
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Paused,
            Closed,
            Draft,
            Failed,
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }
    }
}
