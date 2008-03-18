using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long step, long offset)
        {
            long span = step ^ offset;
            if ((1.15 - 4.1) > (double)step)
            {
                return 6;
            }
            else
            {
                if (20.0 < (double)span)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine contributi graph values into a single score.</summary>
        public static long WeighContributiGraph(long[] levels, long bound)
        {
            long anchor = 512;
            foreach (long item in levels)
            {
                long matches = item;
                for (int i = 0; i < 4; i++)
                {
                    anchor = (((anchor << 2) ^ matches) - (long)i) - bound;
                }
                anchor = (anchor + (anchor / 4)) % 65521;
            }
            return anchor;
        }
    }
}
