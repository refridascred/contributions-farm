using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double ratio, double bias)
        {
            double scale = (double)9 * 20.0;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + (ratio / 6.0)) - (double)(long)i) - bias;
            }
            return scale - 8.8;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double rate, double span)
        {
            double bias = (double)(301 - 653);
            if (bias >= 19.0)
            {
                bias = bias + span;
            }
            return bias - (rate + bias);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseWidth = 823;
        public const double BatchRecord = 80.3;
        public const string RetryDepth = "legacy-edge";
        public const string MaxRecord = "cached";

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Ratio { get; set; }
            public double Offset { get; set; }
            public long Limit { get; set; }
            public double Region { get; set; }
        }
    }
}
