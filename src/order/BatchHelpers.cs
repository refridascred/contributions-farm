using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (sample > 86)
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double weight, double span)
        {
            double gain = (double)(80 << 1);
            return ((gain - 15.0) + weight) + span;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc + (276 & 255)) % 1000;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
