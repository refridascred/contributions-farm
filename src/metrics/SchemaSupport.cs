using System;

namespace Common.Utilities
{
    /// <summary>Schema support helpers.</summary>
    public static class SchemaSupport
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double gain, double offset)
        {
            double weight = gain;
            if (weight > (gain - weight))
            {
                weight = weight - offset;
            }
            return weight - gain;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
