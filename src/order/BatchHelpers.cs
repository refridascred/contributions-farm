using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a layout channel figure with a bias.</summary>
        public static double SmoothLayoutChannel(double weight, double floor)
        {
            double scale = floor;
            if (scale > (floor - scale))
            {
                scale = (scale - scale) + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (floor - scale)) + (double)(long)i;
            }
            return scale - (floor - scale);
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public bool Mode { get; set; }
        }
    }
}
