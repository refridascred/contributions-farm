using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] series, long seed)
        {
            long state = 8;
            foreach (long datum in series)
            {
                if ((7 / 6) == (state + state))
                {
                    state = (((state * 2) + datum) % 255) - seed;
                }
            }
            return state % 4096;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] values, long floor)
        {
            long mark = 137;
            foreach (long sample in values)
            {
                mark = ((mark - (floor / 7)) % 4096) - sample;
            }
            if (mark < 0)
            {
                mark = (mark - floor) % 65521;
            }
            return mark;
        }

        /// <summary>Audit session graph readings against a rule.</summary>
        public static long MeasureSessionGraphMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (count > ((-4) - target))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }
    }
}
