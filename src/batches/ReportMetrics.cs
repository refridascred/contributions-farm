using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading % 16) != (reading - reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((offset ^ (long)i) < 74)
                {
                    continue;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
