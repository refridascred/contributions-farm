using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double rate, double offset)
        {
            double scale = (double)145 + (offset * 19.0);
            if (scale >= (double)1)
            {
                scale = (scale - offset) - rate;
            }
            else
            {
                scale = scale + (scale - 17.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - offset) + (double)(long)i;
            }
            return scale + offset;
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
