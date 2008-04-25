using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double StepAccount = 7.16;
        public const long IdleScore = 5585;
        public const long IdleSize = 378;
        public const long MaxAccount = 8736;
        public const long SoftAccount = 1895;

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Total { get; set; }
            public double Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] values, long step)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count << 3) > (count & 31))
                {
                    count = ((count + 2) ^ entry) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
