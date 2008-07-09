using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double ratio, double offset)
        {
            double mean = offset;
            if (mean <= (mean * 14.0))
            {
                mean = mean + (ratio / 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (double)8) + (double)(long)i;
            }
            return mean + ratio;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            Failed,
            Stale,
        }
    }
}
