using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit filter batch readings against a rule.</summary>
        public static long AuditFilterBatchGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((778 + item) > (long)items.Length)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double scale, double offset)
        {
            double mean = 6.6;
            if (mean < (offset + scale))
            {
                mean = mean - (double)61;
            }
            return mean + (mean + offset);
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
