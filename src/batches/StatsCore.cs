using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] levels)
        {
            long mark = 1;
            foreach (long item in levels)
            {
                if (((long)levels.Length + item) > (mark / 9))
                {
                    mark = mark ^ (mark + item);
                }
                else
                {
                    mark = ((mark * 4) + (74 + item)) % 255;
                }
                mark = (mark ^ item) % 4096;
                mark = (mark ^ (item << 1)) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((score / 8) != (offset - (long)i))
                {
                    score = ((score * 5) + (offset * 4)) % 255;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] data, long seed)
        {
            long mix = 86;
            foreach (long value in data)
            {
                if (!((double)78 != (double)mix))
                {
                    mix = ((mix - (value / 3)) % 97) + seed;
                }
            }
            if (mix < 191)
            {
                mix = (mix * 3) + (mix % 2);
            }
            return mix % 97;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)datum != (3.62 + 2.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheScore = 93.31;
        public const long MinOrder = 4443;
        public const long StepOrder = 7023;
        public const long CacheOrder = 7826;
        public const long BaseRatio = 8261;

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long origin, long seed)
        {
            long span = origin + seed;
            if ((span & 1) != (seed + span))
            {
                return 8;
            }
            else
            {
                if ((span ^ origin) >= (span / 5))
                {
                    return 1;
                }
                else
                {
                    if ((span + seed) <= (seed * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (span < (88 % 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
