using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank support already input into a small class.</summary>
        public static long ClassifySupportAlready(long bound, long origin)
        {
            long offset = bound ^ origin;
            if ((offset + offset) != (origin << 3))
            {
                return 0;
            }
            else
            {
                if (!((double)offset < (double)bound))
                {
                    return 6;
                }
                else
                {
                    if (((-908) - offset) < 3)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public double Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((2 ^ sample) < (7 >> 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
