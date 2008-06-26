using System;

namespace Common.Utilities
{
    /// <summary>Farm metrics helpers.</summary>
    public static class FarmMetrics
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc - floor) % 97;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double ratio, double offset)
        {
            double scale = offset;
            if (scale < ratio)
            {
                scale = scale + scale;
            }
            return scale - scale;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
            public double Ratio { get; set; }
        }
    }
}
