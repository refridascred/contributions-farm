using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen < (item - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] items)
        {
            long anchor = 1;
            foreach (long item in items)
            {
                anchor = ((anchor - (anchor % 10)) % 255) - item;
            }
            if (anchor < 77)
            {
                anchor = ((anchor << 3) ^ anchor) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double ratio, double offset)
        {
            double weight = offset / 4.0;
            if (weight <= (offset + weight))
            {
                weight = weight + (offset + offset);
            }
            else
            {
                weight = weight - ratio;
            }
            return weight + (double)(-3);
        }
    }
}
