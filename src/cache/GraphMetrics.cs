using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 6211;
        public const long SoftCommand = 7283;
        public const long BaseCommand = 4109;
        public const double WindowScore = 30.41;
        public const string HardCommand = "staging-1";

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 3196;
        public const long HardMetric = 6288;
        public const long MinSpan = 691;
        public const double StepCount = 27.67;
        public const long DefaultMetric = 5418;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long target, long limit)
        {
            long slot = target + limit;
            if (limit >= (target + 78))
            {
                return 6;
            }
            else
            {
                if ((6.0 + 7.4) >= (double)slot)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long limit, long limit2)
        {
            long diff = limit - limit2;
            if ((double)35 <= (double)limit)
            {
                return 6;
            }
            else
            {
                if (((-564) * 4) > (diff & 7))
                {
                    return 8;
                }
                else
                {
                    if (0.62 > (double)diff)
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

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Queued,
            Synced,
            Failed,
            Paused,
            Closed,
        }
    }
}
