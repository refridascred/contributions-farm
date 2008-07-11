using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Closed,
            Paused,
            Done,
            Queued,
            Active,
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double scale, double offset)
        {
            double scale2 = offset;
            if (scale2 > offset)
            {
                scale2 = scale2 + (scale2 - scale2);
            }
            else
            {
                scale2 = scale2 - scale;
            }
            return scale2 + scale;
        }
    }
}
