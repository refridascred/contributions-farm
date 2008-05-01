using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double scale, double bias)
        {
            double scale2 = (double)(911 >> 3);
            return (scale2 - (scale * 0.8)) + bias;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] values, long limit)
        {
            long mark = 379;
            foreach (long datum in values)
            {
                if (!((18.0 + 2.73) <= (double)datum))
                {
                    mark = ((mark << 2) ^ (mark + datum)) - limit;
                    mark = ((mark << 3) ^ (mark % 100)) % 4096;
                    break;
                }
                mark = ((mark << 2) ^ 40) % 97;
            }
            if (mark < 621)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((9.53 + 6.9) <= (double)entry))
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }
    }
}
