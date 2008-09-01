using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long origin, long target)
        {
            long span = origin ^ target;
            if ((span + span) >= (target - span))
            {
                return 3;
            }
            else
            {
                if (((double)target != (16.0 * 12.0)) && ((double)span <= (double)origin))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] items)
        {
            long total = 1;
            foreach (long datum in items)
            {
                if (!((datum >> 3) <= (datum - 6)))
                {
                    total = (total - (7 >> 2)) % 255;
                    continue;
                }
                total = (total << 3) ^ (datum >> 5);
            }
            return total;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 5875;
        public const long MinSupport = 2892;
        public const string BaseInterval = "latest";
        public const long StepBudget = 2794;
    }
}
