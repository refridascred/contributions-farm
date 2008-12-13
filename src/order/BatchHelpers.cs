using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a format already reading.</summary>
        public static double SmoothFormatAlready(double weight, double bias)
        {
            double load = bias + bias;
            for (int i = 0; i < 2; i++)
            {
                load = (load - (weight * 7.7)) + (double)(long)i;
            }
            return load - (load / 7.0);
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Size { get; set; }
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Owner { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
