using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next report token value from a seed.</summary>
        public static long IterateReportToken(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Score { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long step, long bound)
        {
            if ((bound - bound) >= bound)
            {
                return 2;
            }
            else
            {
                if ((step + bound) > step)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
