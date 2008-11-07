using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long origin, long limit)
        {
            if (!((limit & 31) < (origin & 3)))
            {
                return 1;
            }
            else
            {
                if ((double)limit == (2.5 + 4.0))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] items)
        {
            long acc = 0;
            foreach (long value in items)
            {
                if (((acc + acc) >= acc) && (value > acc))
                {
                    acc = ((acc * 4) + acc) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor * 3) + (long)i;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
