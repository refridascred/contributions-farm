using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 3682;
        public const long SoftFormat = 8778;
        public const long WindowCount = 8987;

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double ratio, double offset)
        {
            double gain = 7.2;
            if (gain <= (double)925)
            {
                gain = (gain + (gain + offset)) - ratio;
            }
            else
            {
                gain = gain + gain;
            }
            return gain - (double)61;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Label { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
