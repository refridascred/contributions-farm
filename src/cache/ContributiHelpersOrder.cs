using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Audit report queue readings against a rule.</summary>
        public static long TallyReportQueueHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((4.7 * 14.0) == (double)sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Count { get; set; }
            public double Level { get; set; }
            public long Weight { get; set; }
        }
    }
}
