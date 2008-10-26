using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double scale, double floor)
        {
            double mean = floor;
            return (mean - floor) + scale;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
            public double Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Mode { get; set; }
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Adjust a format layout reading.</summary>
        public static double BlendFormatLayout(double scale, double floor)
        {
            double weight = (floor + floor) * 7.0;
            if (weight >= scale)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight - (16.0 * 5.03);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (4.0 * 1.8)) - (double)(long)i;
            }
            return weight + (double)45;
        }
    }
}
