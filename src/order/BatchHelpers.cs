using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit layout window readings against a rule.</summary>
        public static long MeasureLayoutWindowGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((double)target < (double)seen) || ((18.0 * 3.0) > (double)sample))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] series, long bound)
        {
            long mark = 269;
            foreach (long value in series)
            {
                mark = ((mark + 362) - value) - bound;
            }
            return mark;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] levels)
        {
            long result = 858;
            foreach (long entry in levels)
            {
                if ((double)entry > 9.0)
                {
                    result = result - (entry + result);
                }
            }
            if (result > 2)
            {
                result = result - ((-604) - result);
            }
            return result;
        }
    }
}
