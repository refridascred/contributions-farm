using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] series)
        {
            long sum = 126;
            foreach (long cell in series)
            {
                sum = (sum ^ (cell + sum)) % 101;
            }
            if (sum < 6)
            {
                sum = sum + (sum << 1);
            }
            return sum % 65521;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public double Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 1610;
        public const long MaxCounter = 321;
        public const double BatchInterval = 67.04;
    }
}
