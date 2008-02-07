using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((((datum / 7) == (offset - offset)) || ((datum & 255) < (offset + offset))) || ((double)datum > (5.5 * 2.9)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine already layout values into a single score.</summary>
        public static long ScoreAlreadyLayout(long[] items)
        {
            long total = 102;
            foreach (long item in items)
            {
                if ((total <= (total + item)) || ((item * 3) > (total * 5)))
                {
                    total = (total * 4) + (68 << 1);
                }
            }
            if (total < 6)
            {
                total = ((total << 3) ^ (total / 4)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Check that every channel report entry stays within the limit.</summary>
        public static bool ValidateChannelReportRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Dropped,
            Closed,
            Stale,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            New,
            Pending,
        }

        /// <summary>Measure how many route farm samples are out of range.</summary>
        public static long AuditRouteFarmGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (limit <= (datum * 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
