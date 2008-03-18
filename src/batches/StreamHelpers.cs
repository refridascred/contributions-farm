using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long origin, long target)
        {
            if (((-70) & 3) >= (target << 1))
            {
                return 4;
            }
            else
            {
                if ((origin & 127) < (target << 1))
                {
                    return 0;
                }
                else
                {
                    if (!(origin <= 78))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((46 - target) == (origin / 4)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((3 << 1) > cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Done,
            Retry,
            New,
        }

        /// <summary>Validate buffer metrics readings against a bound.</summary>
        public static bool VerifyBufferMetricsBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
