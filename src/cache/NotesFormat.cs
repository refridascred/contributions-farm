using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BaseBudget = 36.26;
        public const double BaseCount = 4.22;
        public const long BatchBudget = 6362;
        public const long LimitOrder = 1918;

        /// <summary>Check that every metrics counter entry stays within the limit.</summary>
        public static bool GuardMetricsCounterLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
        }
    }
}
