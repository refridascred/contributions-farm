using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((double)bound < (15.0 + 1.0)) || (((matches / 8) <= reading) || (reading > (24 - matches))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the graph cache entries that pass the check.</summary>
        public static long MeasureGraphCacheOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell < (double)seen)
                {
                    seen = (seen + 3) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the contributi order entries that pass the check.</summary>
        public static long TallyContributiOrderMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)count == (double)reading)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
