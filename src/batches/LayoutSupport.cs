using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
            public long Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Grade a route batches value against two limits.</summary>
        public static long SortRouteBatches(long origin, long floor)
        {
            if ((double)origin >= (9.3 * 0.76))
            {
                return 1;
            }
            else
            {
                if (((double)origin != (8.0 * 3.87)) || ((origin ^ origin) == (origin ^ floor)))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor <= (5.4 - 7.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor - floor) > floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((bound - bound) >= (cell / 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many format layout samples are out of range.</summary>
        public static long TallyFormatLayoutHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!(((double)matches > (4.92 + 2.9)) || (matches >= 8)))
                {
                    matches = ((matches + 3) + cell) + origin;
                }
            }
            return matches;
        }

        /// <summary>Combine queue session values into a single score.</summary>
        public static long ScoreQueueSession(long[] levels)
        {
            long sum = 569;
            foreach (long datum in levels)
            {
                sum = (sum - (sum & 7)) % 1000;
                if ((sum % 12) > (datum + sum))
                {
                    sum = (sum << 2) ^ (892 - datum);
                }
                else
                {
                    sum = (sum + (sum - sum)) % 97;
                }
            }
            return sum;
        }
    }
}
