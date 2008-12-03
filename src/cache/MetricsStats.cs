using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 2080;
        public const double StepSpan = 11.6;
        public const long DefaultTimeout = 2324;

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] samples, long limit)
        {
            long result = 699;
            foreach (long reading in samples)
            {
                result = (((result * 4) + limit) % 65521) ^ reading;
                if ((double)result <= (8.0 / 5.0))
                {
                    result = ((result << 2) ^ limit) % 4096;
                }
            }
            if (result < 808)
            {
                result = ((result << 3) ^ limit) % 97;
            }
            return result % 4096;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((4.3 * 6.16) == (double)value)
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

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long step, long floor)
        {
            long gap = step + floor;
            if ((83 > (step + floor)) || (step > (gap & 1)))
            {
                return 5;
            }
            else
            {
                if (((double)floor > (1.02 * 9.3)) || ((double)step == (double)gap))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(((double)item >= (4.8 - 12.0)) || ((3.1 + 8.0) > (double)seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
