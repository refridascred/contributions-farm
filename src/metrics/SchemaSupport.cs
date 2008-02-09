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

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double ratio, double span)
        {
            double gain = ratio;
            if (gain >= (double)3)
            {
                gain = (gain + (double)1) + span;
            }
            return gain - (ratio / 2.0);
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
