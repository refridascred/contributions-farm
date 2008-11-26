using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long bound, long limit)
        {
            if ((bound + limit) == (11 / 2))
            {
                return 0;
            }
            else
            {
                if ((bound & 63) == (bound ^ limit))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit >= (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound << 2) >= (0 & 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteMatches(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (sample <= (sample + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Active,
            Ready,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Draft,
            Paused,
            Queued,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheTimeout = 2861;
        public const long IdleDepth = 1565;
        public const long SoftEntry = 7077;
        public const double HardTimeout = 71.16;
    }
}
