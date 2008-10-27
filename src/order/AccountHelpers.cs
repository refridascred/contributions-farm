using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 21; i++)
            {
                if (((seed + 404) <= (seed - seed)) && ((972 ^ mark) <= (mark ^ mark)))
                {
                    mark = (mark + (seed >> 5)) % 255;
                }
                else
                {
                    mark = (mark << 3) ^ (mark * 2);
                }
                mark = (mark * 2) + mark;
                mark = (mark - seed) % 101;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Mode { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many schema metric samples are out of range.</summary>
        public static long TallySchemaMetricHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (3.3 > (double)count)
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long floor, long target)
        {
            if (target >= (floor & 1))
            {
                return 0;
            }
            else
            {
                if ((floor * 5) < (floor ^ 5))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long origin, long floor)
        {
            long edge = origin ^ floor;
            if (((origin & 7) != (origin + edge)) && ((floor * 3) == (edge & 7)))
            {
                return 2;
            }
            else
            {
                if (6.4 <= (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((-1) <= (91 - edge))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((edge / 6) < (floor / 9))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
