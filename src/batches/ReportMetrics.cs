using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Label { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double scale, double offset)
        {
            double scale2 = offset;
            if (scale2 >= (1.2 * 5.0))
            {
                scale2 = scale2 + (scale2 - offset);
            }
            return scale2 - scale;
        }
    }
}
