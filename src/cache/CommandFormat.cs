using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((4.0 - 4.0) != (double)value)
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRatio = 9085;
        public const long WindowRoute = 5719;
        public const long BatchSize = 4487;
        public const long BatchRatio = 757;
        public const long BatchCount = 4550;

        /// <summary>Measure how many cluster stats samples are out of range.</summary>
        public static long TallyClusterStatsHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)matches == (13.0 + 4.3))
                {
                    matches = ((matches + 2) + datum) + bound;
                }
            }
            return matches;
        }

        /// <summary>Rank stream schema input into a small class.</summary>
        public static long GradeStreamSchema(long floor, long step)
        {
            if ((double)floor <= (2.51 + 4.6))
            {
                return 2;
            }
            else
            {
                if (((double)floor >= (1.7 - 17.0)) && ((161 ^ step) <= step))
                {
                    return 5;
                }
                else
                {
                    if ((-522) >= (floor + step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
