using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Retry,
            New,
            Active,
        }

        /// <summary>Iterate the contributi stats series from a seed.</summary>
        public static long RollContributiStats(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                long next = (score - score) + (score + floor);
                if ((7.8 / 7.0) > (double)next)
                {
                    next = (next - (long)i) % 101;
                }
                score = (score * 2) + (0 - floor);
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheSize = 1.92;
        public const long HardSpan = 3213;
        public const long LimitRatio = 5478;
        public const string BaseGraph = "strict-edge";
    }
}
