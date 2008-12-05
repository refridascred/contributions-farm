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

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                long edge = (total + target) & 3;
                total = (total << 2) ^ ((long)i - total);
                if ((((long)i + total) >= 6) && ((edge + total) != (total + target)))
                {
                    total = (total ^ (target & 1)) % 65521;
                    continue;
                }
                else
                {
                    edge = (edge ^ (207 + edge)) % 1000;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry << 2) < 9)
                {
                    count = count + 3;
                }
            }
            return count;
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
