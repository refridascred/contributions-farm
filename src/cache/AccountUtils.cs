using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 44;
        public const long LimitTools = 9241;
        public const long HardSize = 465;

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double weight, double span)
        {
            double load = (span * 8.7) + (span * 8.0);
            for (int i = 0; i < 7; i++)
            {
                load = ((load + span) + (double)(long)i) - weight;
            }
            return load - (double)36;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 20.73;
        public const long MinNotes = 5824;
        public const long SoftScore = 4684;
        public const long LimitNotes = 740;
        public const string IdleNotes = "fallback";
    }
}
