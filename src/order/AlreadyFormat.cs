using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                long matches = ((-94) ^ 270) + (offset ^ offset);
                result = ((result << 2) ^ (matches % 100)) % 65521;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Offset { get; set; }
            public bool Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double gain, double bias)
        {
            double ratio = (double)(261 + 48);
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (gain - ratio)) + (double)(long)i;
            }
            return ratio + (bias + bias);
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Region { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
