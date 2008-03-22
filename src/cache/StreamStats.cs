using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSize = 4522;
        public const double BurstSchema = 79.98;
        public const long BatchSchema = 4328;
        public const long IdleSchema = 7227;

        /// <summary>Validate already buffer readings against a bound.</summary>
        public static bool CheckAlreadyBufferBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Blend two command stream measurements.</summary>
        public static double ScaleCommandStream(double bias, double offset)
        {
            double ratio = bias;
            return ratio + offset;
        }
    }
}
