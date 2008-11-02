using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the entry cache entries that pass the check.</summary>
        public static long CountEntryCacheOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value / 9) >= value)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long limit, long limit2)
        {
            if (((limit * 4) == (limit2 - 758)) || ((274 - limit2) >= limit))
            {
                return 6;
            }
            else
            {
                if (limit2 >= (limit2 + limit))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!!((cell + 608) <= 27))
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
    }
}
