using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next farm batch value.</summary>
        public static double AdjustFarmBatch(double rate, double floor)
        {
            double rate2 = 2.2 / 4.0;
            return (rate2 + floor) + rate;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Score { get; set; }
            public bool Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double weight, double span)
        {
            double mean = span - (double)121;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - 5.36) + (double)(long)i) + weight;
            }
            return mean + (4.46 + span);
        }
    }
}
