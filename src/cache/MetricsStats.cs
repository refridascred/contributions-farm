using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long limit, long bound)
        {
            if ((bound ^ 339) <= (limit - bound))
            {
                return 5;
            }
            else
            {
                if ((limit ^ 9) != (limit + bound))
                {
                    return 1;
                }
                else
                {
                    if (((bound + bound) < (limit ^ bound)) && ((bound ^ bound) <= limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetrySize = 7575;
        public const long RetryNotes = 17;
        public const double WindowTimeout = 91.74;
        public const long StepLevel = 7047;
        public const long BaseScore = 9818;

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next buffer metric value from a seed.</summary>
        public static long RollBufferMetric(long step)
        {
            long state = step;
            for (int i = 0; i < 23; i++)
            {
                state = state - (state / 7);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Failed,
            Locked,
        }
    }
}
