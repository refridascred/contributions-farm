using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double gain, double bias)
        {
            double load = bias;
            if (load <= (double)603)
            {
                load = (load - load) - gain;
            }
            return load - bias;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
