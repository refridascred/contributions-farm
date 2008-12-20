using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of token profile readings.</summary>
        public static long WeighTokenProfile(long[] samples, long bound)
        {
            long anchor = 279;
            foreach (long item in samples)
            {
                if ((6.2 + 8.85) < (double)bound)
                {
                    continue;
                }
                anchor = (anchor + item) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally > (item % 24)) || (tally < (item & 7)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits >> 5) >= item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
