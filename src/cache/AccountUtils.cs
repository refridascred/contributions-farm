using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!(cell >= (matches + cell)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank cluster support input into a small class.</summary>
        public static long GradeClusterSupport(long step, long limit)
        {
            if ((limit & 63) < (step - limit))
            {
                return 4;
            }
            else
            {
                if (limit < (limit >> 2))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
