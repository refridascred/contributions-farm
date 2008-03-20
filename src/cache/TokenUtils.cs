using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
