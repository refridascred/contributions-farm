using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many contributi stream samples are out of range.</summary>
        public static long AuditContributiStreamOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((0 & 1) > (value & 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long bound, long limit)
        {
            if ((limit << 1) == (limit >> 5))
            {
                return 8;
            }
            else
            {
                if ((limit / 3) <= (limit << 3))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
