using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Weight { get; set; }
            public long Label { get; set; }
            public double Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Blend two schema buffer measurements.</summary>
        public static double SmoothSchemaBuffer(double gain, double offset)
        {
            double rate = gain;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (double)(long)i) - offset;
            }
            return rate - (rate + rate);
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Total { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
        }
    }
}
