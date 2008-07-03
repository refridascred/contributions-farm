using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long limit, long step)
        {
            long offset = limit ^ step;
            if ((offset & 31) < (limit - limit))
            {
                return 3;
            }
            else
            {
                if (limit < (4 * 4))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long floor, long step)
        {
            long prev = floor + step;
            if (floor <= (step / 2))
            {
                return 3;
            }
            else
            {
                if ((floor & 7) <= (prev >> 3))
                {
                    return 7;
                }
                else
                {
                    if ((prev < (prev ^ step)) && (step >= (step - step)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 6506;
        public const double LimitRatio = 1.83;
        public const double RetryQueue = 92.88;

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((4.61 + 9.0) == (double)value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
        }
    }
}
