using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 1890;
        public const long BurstCounter = 5030;
        public const double BurstSpan = 87.93;
        public const long StepCounter = 8193;
        public const long MaxCounter = 4015;

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long step)
        {
            long total = step;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Queued,
            Locked,
            New,
            Done,
            Draft,
        }
    }
}
