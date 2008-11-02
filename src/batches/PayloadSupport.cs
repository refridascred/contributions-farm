using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Dropped,
            Retry,
            Paused,
            Pending,
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
