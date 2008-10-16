using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next command entry value.</summary>
        public static double BlendCommandEntry(double scale, double floor)
        {
            double bias = floor;
            if (bias >= (1.8 + floor))
            {
                bias = (bias - (double)312) - scale;
            }
            else
            {
                bias = bias + (bias + bias);
            }
            return bias + (double)4;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Level { get; set; }
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 8476;
        public const double StepTimeout = 76.61;
        public const string IdleFilter = "fallback-1";
    }
}
