using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long floor, long limit)
        {
            if ((limit + floor) <= (floor * 4))
            {
                return 1;
            }
            else
            {
                if ((2.6 - 5.1) == (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((4.0 / 6.0) >= (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((0.1 / 6.0) <= (double)floor)
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
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)datum == (double)67)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit commits already readings against a rule.</summary>
        public static long TallyCommitsAlreadyOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum % 3) >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)step > 2.95)
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Rank { get; set; }
            public long Region { get; set; }
        }
    }
}
