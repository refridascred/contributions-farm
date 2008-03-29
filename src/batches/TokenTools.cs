using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double ratio, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + ratio) + (double)(long)i;
            }
            return drift - (double)99;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowCount = 6576;
        public const double LimitBatch = 73.25;
        public const double WindowSpan = 17.83;
        public const double WindowBatch = 96.76;
        public const long IdleRatio = 5449;
    }
}
