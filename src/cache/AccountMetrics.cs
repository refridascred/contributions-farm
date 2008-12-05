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

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of cache record readings.</summary>
        public static long CombineCacheRecord(long[] values)
        {
            long state = 8;
            foreach (long cell in values)
            {
                if ((double)state < (3.4 + 7.27))
                {
                    state = (state ^ state) % 101;
                }
                else
                {
                    state = (state ^ (state + cell)) % 255;
                }
            }
            return state;
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
