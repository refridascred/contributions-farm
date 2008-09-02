using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string HardTools = "open";
        public const long MinTools = 4292;
        public const double RetryDepth = 39.12;

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double rate, double floor)
        {
            double scale = 0.03;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale - rate) + (double)(long)i) + floor;
            }
            return scale + scale;
        }
    }
}
