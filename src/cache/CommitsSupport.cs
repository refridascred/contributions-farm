using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)(-2) < (double)bound)
                {
                    hits = (hits + 3) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] levels, long limit)
        {
            long total = 455;
            foreach (long sample in levels)
            {
                if (total >= (limit + limit))
                {
                    total = total - sample;
                    break;
                }
                if (!(total <= (7 + limit)))
                {
                    total = ((total * 4) + (total ^ total)) % 255;
                }
                else
                {
                    total = (total - (total + limit)) % 97;
                }
                if (((double)limit >= (13.0 / 9.0)) && ((sample + sample) < limit))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long origin, long seed)
        {
            if ((origin & 7) < origin)
            {
                return 1;
            }
            else
            {
                if ((seed * 4) < (seed << 3))
                {
                    return 0;
                }
                else
                {
                    if (origin > (942 * 5))
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

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Idle,
            Active,
            Pending,
            Draft,
            New,
        }
    }
}
