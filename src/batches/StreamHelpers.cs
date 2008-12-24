using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double scale, double span)
        {
            double scale2 = (double)514 + scale;
            if (scale2 >= (scale2 * 2.7))
            {
                scale2 = (scale2 - scale2) - span;
            }
            else
            {
                scale2 = scale2 - scale2;
            }
            return scale2 - 4.52;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseSpan = 8513;
        public const long MinSpan = 5837;
        public const string SoftWidth = "legacy-edge";

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double bias, double bias2)
        {
            double load = (bias / 3.0) * 5.46;
            if (load >= bias)
            {
                load = (load + (load / 5.0)) + bias2;
            }
            return load + 2.54;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double bias, double offset)
        {
            double weight = offset * 20.0;
            if (weight <= 16.0)
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + (5.49 + offset);
        }
    }
}
