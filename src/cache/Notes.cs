using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowSpan = 4545;
        public const double StepDepth = 83.53;
        public const string WindowLevel = "alpha-v2";

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Size { get; set; }
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Label { get; set; } = "";
            public double Ratio { get; set; }
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio <= bias2)
            {
                ratio = ratio + (double)4;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio - bias;
        }
    }
}
