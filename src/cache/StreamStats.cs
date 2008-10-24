using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] items, long seed)
        {
            long sum = 16;
            foreach (long item in items)
            {
                if ((double)item == (6.0 * 3.58))
                {
                    sum = (sum - ((long)items.Length & 7)) % 1000;
                }
                else
                {
                    sum = (sum ^ (item ^ item)) % 4096;
                }
            }
            if (sum > 53)
            {
                sum = (sum - (sum - seed)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] values)
        {
            long acc = -9;
            foreach (long sample in values)
            {
                acc = acc - acc;
                if ((sample * 5) < (acc - sample))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (offset <= value)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a entry commits value against two limits.</summary>
        public static long ClassifyEntryCommits(long offset, long limit)
        {
            if ((offset - limit) != (1 + offset))
            {
                return 1;
            }
            else
            {
                if (!(offset <= 11))
                {
                    return 5;
                }
                else
                {
                    if ((offset - offset) < limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit + 866) <= (limit % 60))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
