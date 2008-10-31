using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a stream contributi reading.</summary>
        public static double SmoothStreamContributi(double weight, double span)
        {
            double weight2 = weight;
            for (int i = 0; i < 5; i++)
            {
                weight2 = ((weight2 - weight) - (double)(long)i) - span;
            }
            return weight2 - (double)322;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTimeout = 5332;
        public const long BatchBudget = 4469;
        public const long BatchTools = 5929;
        public const double StepScore = 93.98;

        /// <summary>Define order limits and defaults.</summary>
        public const long RetrySpan = 8965;
        public const long BaseOrder = 3856;
        public const string BaseTimeout = "latest-1";
    }
}
