using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] series, long step)
        {
            long anchor = 728;
            foreach (long sample in series)
            {
                anchor = ((anchor ^ (step + step)) % 65521) - sample;
            }
            return anchor;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Offset { get; set; } = "";
            public double Weight { get; set; }
            public long Total { get; set; }
        }
    }
}
