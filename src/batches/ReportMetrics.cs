using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long step, long seed)
        {
            long offset = step ^ seed;
            if (!((7.63 / 8.0) <= (double)offset))
            {
                return 8;
            }
            else
            {
                if (!((double)seed <= (2.4 - 7.02)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit metrics cluster readings against a rule.</summary>
        public static long MeasureMetricsClusterHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((tally - step) > (71 << 2)) && !((55 ^ tally) > (tally - step)))
                {
                    tally = (tally + 1) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Mode { get; set; } = "";
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
        }
    }
}
