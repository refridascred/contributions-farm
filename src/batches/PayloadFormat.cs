using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry <= (entry + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i + (long)i) >= (bound + carry))
                {
                    carry = carry + (long)i;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Rank entry metrics input into a small class.</summary>
        public static long ClassifyEntryMetrics(long bound, long bound2)
        {
            if (!((937 - bound2) <= bound))
            {
                return 4;
            }
            else
            {
                if ((3.5 * 17.0) < (double)bound2)
                {
                    return 5;
                }
                else
                {
                    if ((bound2 / 4) >= (422 - bound2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum - count) > (6 >> 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
