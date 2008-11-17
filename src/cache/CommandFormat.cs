using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Mode { get; set; }
            public long Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((double)tally < 3.2)
                {
                    tally = (tally + 2) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            Closed,
            Locked,
            Draft,
        }
    }
}
