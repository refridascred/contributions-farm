using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit order githubfarm readings against a rule.</summary>
        public static long CountOrderGithubfarmGaps(long[] readings, long origin)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((origin + cell) != (origin << 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Ratio { get; set; }
            public double Weight { get; set; }
            public double Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Stamp { get; set; }
            public double Level { get; set; }
        }
    }
}
