using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double weight, double offset)
        {
            double weight2 = weight - offset;
            if (weight2 <= offset)
            {
                weight2 = weight2 - weight2;
            }
            else
            {
                weight2 = weight2 - weight;
            }
            return weight2 - 3.7;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Done,
            Dropped,
            Queued,
            Synced,
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double bias, double span)
        {
            double weight = 14.0;
            if (weight < span)
            {
                weight = weight + (bias - bias);
            }
            else
            {
                weight = weight - (span / 4.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (weight * 3.8)) + (double)(long)i;
            }
            return weight + (4.4 + 16.0);
        }
    }
}
