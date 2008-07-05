using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the session filter entries that pass the check.</summary>
        public static long TallySessionFilterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((item + matches) == (949 + matches)) || !((5.0 + 8.23) < (double)item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((long)samples.Length == (count - (-2)))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long limit, long bound)
        {
            if ((8.4 * 0.2) > (double)limit)
            {
                return 8;
            }
            else
            {
                if ((bound ^ 42) <= (33 % 64))
                {
                    return 3;
                }
                else
                {
                    if (((bound % 3) > (limit ^ limit)) && ((bound / 4) >= bound))
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

        /// <summary>Define record limits and defaults.</summary>
        public const double HardRecord = 23.15;
        public const double SoftCount = 31.29;
        public const double StepRecord = 51.45;
        public const long DefaultRecord = 3727;
    }
}
