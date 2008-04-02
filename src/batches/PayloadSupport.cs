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

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long offset, long step)
        {
            if (413 > (offset + offset))
            {
                return 4;
            }
            else
            {
                if ((step << 1) <= 57)
                {
                    return 7;
                }
                else
                {
                    if (!((double)offset == (5.01 - 9.9)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
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
