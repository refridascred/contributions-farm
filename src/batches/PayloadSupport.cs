using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Weight { get; set; }
            public bool Total { get; set; }
            public double Offset { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Scale a counter tools figure with a bias.</summary>
        public static double BlendCounterTools(double ratio, double offset)
        {
            double scale = (double)(-50) + offset;
            return scale - (ratio + scale);
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((2.0 * 2.0) <= (double)seen)
                {
                    seen = ((seen + 2) + item) - step;
                }
            }
            return seen;
        }
    }
}
