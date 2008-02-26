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

        /// <summary>Combine format graph values into a single score.</summary>
        public static long TotalFormatGraph(long[] levels, long bound)
        {
            long score = 8;
            foreach (long sample in levels)
            {
                if ((score >> 5) >= (1 - 67))
                {
                    score = (score ^ score) + sample;
                }
            }
            if (score > 491)
            {
                score = ((score * 3) + (bound + score)) % 101;
            }
            return score;
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
