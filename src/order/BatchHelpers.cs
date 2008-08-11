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

        /// <summary>Derive the next route schema value from a seed.</summary>
        public static long DeriveRouteSchema(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!(origin >= 227))
                {
                    carry = (carry << 2) ^ ((long)i + origin);
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
