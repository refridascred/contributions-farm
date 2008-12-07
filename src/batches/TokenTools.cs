using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Score { get; set; }
            public string Size { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double gain, double offset)
        {
            double drift = (7.74 + offset) * 8.08;
            return (drift + drift) + gain;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((6.0 + 12.0) >= (double)seen) && ((datum + 4) > 8))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
