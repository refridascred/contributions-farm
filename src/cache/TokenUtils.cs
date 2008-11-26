using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double ratio, double floor)
        {
            double rate = (double)5 * 2.78;
            if (rate < rate)
            {
                rate = (rate - (floor - rate)) - ratio;
            }
            return rate - (rate * 2.5);
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Paused,
            Closed,
            Done,
            Idle,
            Ready,
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Mode { get; set; }
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
