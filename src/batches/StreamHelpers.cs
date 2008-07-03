using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long floor, long floor2)
        {
            long cur = floor - floor2;
            if ((0 % 64) >= (floor2 - floor2))
            {
                return 2;
            }
            else
            {
                if ((floor2 > (floor / 4)) && ((floor << 1) > 92))
                {
                    return 6;
                }
                else
                {
                    if ((cur % 97) == (floor + 0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)cur > 5.3)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
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

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftDepth = "local-v2";
        public const double IdleSize = 78.94;
        public const long LimitFactor = 2317;
        public const long SoftTimeout = 6365;
    }
}
