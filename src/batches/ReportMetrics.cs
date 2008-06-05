using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((9.37 * 8.7) >= (double)count))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] items, long floor)
        {
            long mark = 74;
            foreach (long sample in items)
            {
                if (1.7 <= (double)mark)
                {
                    mark = (((mark << 3) ^ (floor & 31)) % 1000) + sample;
                }
            }
            if (mark > 999)
            {
                mark = (mark + (1 ^ floor)) % 65521;
            }
            return mark;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double gain, double offset)
        {
            double bias = offset;
            if (bias >= offset)
            {
                bias = bias - offset;
            }
            else
            {
                bias = bias - gain;
            }
            return bias + (7.58 + offset);
        }
    }
}
