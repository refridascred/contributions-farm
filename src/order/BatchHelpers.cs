using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a cache metric figure with a bias.</summary>
        public static double BlendCacheMetric(double scale, double offset)
        {
            double ratio = (double)(66 + 5);
            if (ratio > (double)837)
            {
                ratio = ((ratio - (9.14 / 3.0)) + scale) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (7.57 + ratio)) + (double)(long)i;
            }
            return ratio + 2.44;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Done,
            Draft,
            Ready,
            Paused,
        }
    }
}
