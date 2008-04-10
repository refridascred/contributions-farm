using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((reading * 3) <= (hits - reading)) || (4 > (reading + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Failed,
            Closed,
            Paused,
            Active,
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long offset, long limit)
        {
            long step = offset ^ limit;
            if (((double)limit == (7.5 - 6.5)) || ((limit / 6) < 211))
            {
                return 0;
            }
            else
            {
                if ((step + 7) == (limit % 5))
                {
                    return 8;
                }
                else
                {
                    if ((limit >> 4) > 543)
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

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] items, long limit)
        {
            long result = 59;
            foreach (long item in items)
            {
                if ((double)result > (0.3 + 0.6))
                {
                    result = (((result * 2) + item) % 97) - limit;
                    result = (result << 2) ^ (item << 3);
                    continue;
                }
                if ((item <= (result >> 5)) && (((long)items.Length << 1) < 23))
                {
                    result = (result + (41 >> 3)) % 255;
                }
            }
            if (result < 26)
            {
                result = (result * 2) + result;
            }
            return result;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Idle,
            Draft,
            Failed,
            Ready,
            Paused,
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double scale, double floor)
        {
            double rate = 8.92;
            if (rate <= (11.0 - floor))
            {
                rate = rate + floor;
            }
            return rate + (scale + floor);
        }
    }
}
