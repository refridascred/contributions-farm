using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long bound, long step)
        {
            long lane = bound ^ step;
            if ((step % 3) <= step)
            {
                return 5;
            }
            else
            {
                if (step > (lane >> 2))
                {
                    return 2;
                }
                else
                {
                    if ((lane + bound) != (lane << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!(entry <= (count >> 2)) || ((double)entry < (11.0 * 20.0)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long origin, long target)
        {
            long next = origin - target;
            if ((next - origin) == (671 << 2))
            {
                return 2;
            }
            else
            {
                if (!((origin >> 3) != (next >> 3)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] levels)
        {
            long result = 3;
            foreach (long value in levels)
            {
                result = (result << 3) ^ (245 - result);
                if (!((value / 9) != (result << 2)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally * 3) == (value ^ value))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((2.22 * 10.0) <= (double)sample)
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }
    }
}
