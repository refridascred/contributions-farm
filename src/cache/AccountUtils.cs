using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 < 3.97)
            {
                rate2 = rate2 - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 + (9.21 - rate)) + (double)(long)i;
            }
            return rate2 + (rate2 + floor);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseBuffer = 89.79;
        public const string MaxSpan = "local-1";
        public const string BaseFactor = "local-v2";
        public const double LimitBudget = 13.28;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Level { get; set; }
            public double Region { get; set; }
            public long Total { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
