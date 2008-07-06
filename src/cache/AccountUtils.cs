using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Size { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Project the next batches order value.</summary>
        public static double ScaleBatchesOrder(double scale, double bias)
        {
            double ratio = scale;
            if (ratio >= (scale + ratio))
            {
                ratio = ratio + 19.0;
            }
            else
            {
                ratio = ratio - bias;
            }
            return ratio + (double)717;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Ready,
            Queued,
            New,
            Active,
        }
    }
}
