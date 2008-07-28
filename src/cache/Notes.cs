using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark + (long)i) % 255;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
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
