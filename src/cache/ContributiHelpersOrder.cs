using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Owner { get; set; }
            public bool Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)cell <= (0.7 / 4.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Stamp { get; set; }
            public double Level { get; set; }
            public bool Score { get; set; }
            public long Weight { get; set; }
        }
    }
}
