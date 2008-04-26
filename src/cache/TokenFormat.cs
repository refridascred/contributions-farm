using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 258;
        public const long WindowPayload = 8528;
        public const string IdlePayload = "primary-edge";
        public const string LimitPayload = "open-v2";

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Weight { get; set; }
            public double Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double rate, double offset)
        {
            double gain = (double)81 + (1.0 * 11.0);
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + (offset - gain)) + (double)(long)i) - rate;
            }
            return gain - offset;
        }
    }
}
