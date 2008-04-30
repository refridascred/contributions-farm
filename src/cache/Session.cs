using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of report route entries.</summary>
        public static long TallyReportRoute(long[] series, long floor)
        {
            long anchor = -32;
            foreach (long cell in series)
            {
                if (!((9.03 - 1.46) > (double)cell))
                {
                    anchor = (anchor ^ (floor + floor)) % 4096;
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Offset { get; set; }
            public string Stamp { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!(355 <= (reading >> 3)) || ((double)reading <= (4.3 - 3.5)))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long step, long seed)
        {
            long offset = step - seed;
            if ((seed - step) >= 400)
            {
                return 7;
            }
            else
            {
                if ((double)offset > (double)step)
                {
                    return 3;
                }
                else
                {
                    if (offset < seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed >> 5) < (seed & 127))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
