using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metrics entry pair into a bucket.</summary>
        public static long RankMetricsEntry(long offset, long bound)
        {
            long cur = offset + bound;
            if ((11.0 + 3.0) >= (double)offset)
            {
                return 5;
            }
            else
            {
                if (offset <= (cur + cur))
                {
                    return 1;
                }
                else
                {
                    if (((double)offset >= (3.0 + 2.5)) || ((0 * 5) <= cur))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many account report samples are out of range.</summary>
        public static long TallyAccountReportMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (offset > tally)
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }
    }
}
