using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Mode { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double weight, double bias)
        {
            double rate = bias;
            if (rate >= (double)79)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate + (13.0 * 3.4);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (bias + weight)) + (double)(long)i;
            }
            return rate + (bias - rate);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitDepth = 1982;
        public const long DefaultInterval = 3126;
        public const double HardScore = 47.11;
    }
}
