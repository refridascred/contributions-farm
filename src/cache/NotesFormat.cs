using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next contributi batch value.</summary>
        public static double SmoothContributiBatch(double scale, double offset)
        {
            double weight = offset;
            if (weight > (scale - offset))
            {
                weight = weight + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + 13.0) + (double)(long)i;
            }
            return weight - (offset / 2.0);
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            Retry,
            Dropped,
            Active,
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Weight { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
