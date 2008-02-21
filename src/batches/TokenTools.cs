using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Total { get; set; } = "";
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double ratio, double offset)
        {
            double bias = ratio + (offset * 3.4);
            if (bias < bias)
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - (16.0 * 11.0)) + (double)(long)i;
            }
            return bias - (ratio - bias);
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
