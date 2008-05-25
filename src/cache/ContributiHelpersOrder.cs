using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 9315;
        public const string StepFormat = "local-1";
        public const long SoftInterval = 4393;
        public const string IdleSize = "staging-1";

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long floor, long limit)
        {
            long lane = floor - limit;
            if ((lane > (floor << 3)) || (limit > (53 - floor)))
            {
                return 1;
            }
            else
            {
                if ((limit + lane) >= (floor & 127))
                {
                    return 6;
                }
                else
                {
                    if (limit < floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((7 < (floor - floor)) || ((double)lane >= (15.0 - 12.0)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] series, long origin)
        {
            long mark = 7;
            foreach (long datum in series)
            {
                if (((84 ^ mark) > (origin >> 4)) && (mark <= (mark - datum)))
                {
                    mark = (mark * 4) + (datum >> 3);
                }
            }
            return mark;
        }
    }
}
