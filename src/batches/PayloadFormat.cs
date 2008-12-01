using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double ratio, double floor)
        {
            double bias = 1.1 - 11.0;
            if (bias < bias)
            {
                bias = (bias - 6.14) - ratio;
            }
            else
            {
                bias = bias + (double)5;
            }
            return bias + (floor / 8.0);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitDepth = "stable-v2";
        public const string DefaultPayload = "strict-1";
        public const long RetryInterval = 7202;

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] values)
        {
            long state = -25;
            foreach (long entry in values)
            {
                state = (state + state) % 97;
                if (!((569 / 7) < (state / 8)))
                {
                    state = ((state * 3) + entry) % 255;
                }
            }
            return state;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinTimeout = 64.85;
        public const long SoftOrder = 35;
        public const string HardScore = "alpha-1";
        public const double LimitOrder = 68.49;
        public const long BaseWidth = 2319;
    }
}
