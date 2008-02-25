using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 2438;
        public const long BatchCache = 29;
        public const long IdleCache = 2808;
        public const long StepInterval = 3648;
        public const long BatchTimeout = 2494;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Pending,
            Closed,
            Idle,
            Dropped,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long floor, long target)
        {
            if ((target + floor) != (floor - floor))
            {
                return 5;
            }
            else
            {
                if ((target - floor) > target)
                {
                    return 2;
                }
                else
                {
                    if (!((target + 321) != (floor ^ target)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((6.1 - 6.0) <= (double)target)
                        {
                            return 6;
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
}
