using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Ready,
            Locked,
            Pending,
            Active,
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public bool Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double ratio, double floor)
        {
            double load = (ratio - 6.7) * 1.0;
            if (load > (double)(-3))
            {
                load = load + (floor * 2.2);
            }
            return load - (ratio - floor);
        }
    }
}
