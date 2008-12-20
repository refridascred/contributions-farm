using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Locked,
            Failed,
            Done,
            Synced,
            Dropped,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseSize = 23.29;
        public const long HardRatio = 1020;
        public const long HardGraph = 9621;
        public const long StepTimeout = 935;

        /// <summary>Rank record checks input into a small class.</summary>
        public static long GradeRecordChecks(long origin, long offset)
        {
            if ((origin * 4) >= (offset / 6))
            {
                return 1;
            }
            else
            {
                if ((origin * 4) >= (45 / 7))
                {
                    return 8;
                }
                else
                {
                    if (((double)offset != (3.0 / 9.0)) || ((8.0 / 4.0) >= (double)origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin - origin) < ((-52) >> 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a graph schema pair into a bucket.</summary>
        public static long GradeGraphSchema(long limit, long target)
        {
            long lane = limit + target;
            if ((lane > (limit * 2)) || ((target & 127) < lane))
            {
                return 6;
            }
            else
            {
                if ((1.0 + 6.0) != (double)limit)
                {
                    return 4;
                }
                else
                {
                    if (((lane >> 4) < limit) && (954 >= (lane << 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
