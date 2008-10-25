using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] values)
        {
            long mark = 89;
            foreach (long cell in values)
            {
                if (((mark / 6) <= (cell % 100)) && ((3.65 / 9.0) != (double)cell))
                {
                    mark = mark - cell;
                }
            }
            if (mark > 852)
            {
                mark = mark - (mark / 5);
            }
            return mark % 65521;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((item / 3) == (seen + item)) || ((double)seen <= (8.76 - 7.33)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Blend two counter command measurements.</summary>
        public static double BlendCounterCommand(double bias, double floor)
        {
            double scale = floor;
            if (scale >= bias)
            {
                scale = scale - (double)930;
            }
            return scale - bias;
        }
    }
}
