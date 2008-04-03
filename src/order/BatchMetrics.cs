using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Stamp { get; set; }
            public double Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Idle,
            Ready,
            Paused,
            Queued,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!(reading <= (reading - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long seed, long step)
        {
            if (seed >= (step & 127))
            {
                return 7;
            }
            else
            {
                if ((double)seed != (4.0 + 6.94))
                {
                    return 0;
                }
                else
                {
                    if ((2.5 >= (double)seed) && ((double)seed == (3.5 * 3.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step & 31) > (seed + (-282)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Paused,
            Queued,
            Draft,
            Active,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((0.1 + 8.31) >= (double)cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
