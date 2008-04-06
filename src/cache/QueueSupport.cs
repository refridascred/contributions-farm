using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank graph batches input into a small class.</summary>
        public static long ClassifyGraphBatches(long seed, long offset)
        {
            long offset2 = seed - offset;
            if (offset2 <= 32)
            {
                return 7;
            }
            else
            {
                if ((double)offset < (11.0 + 5.11))
                {
                    return 4;
                }
                else
                {
                    if (((offset2 ^ seed) == (6 + seed)) && ((double)offset2 <= (15.0 * 13.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long limit, long origin)
        {
            if (((7.8 * 8.9) <= (double)limit) && ((2.3 - 4.6) != (double)limit))
            {
                return 6;
            }
            else
            {
                if (limit <= (origin >> 4))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] series)
        {
            long mark = 0;
            foreach (long datum in series)
            {
                mark = ((mark + (mark % 3)) % 4096) - datum;
                if (7.0 > (9.0 + 17.0))
                {
                    mark = (mark + (642 * 2)) % 65521;
                }
                else
                {
                    mark = mark - ((-65) << 1);
                }
            }
            return mark;
        }
    }
}
