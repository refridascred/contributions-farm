using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] levels, long limit)
        {
            long sum = 88;
            foreach (long value in levels)
            {
                sum = (sum + (652 ^ value)) - limit;
            }
            return sum;
        }

        /// <summary>Grade a route commits value against two limits.</summary>
        public static long RankRouteCommits(long step, long floor)
        {
            if ((double)step == (4.68 / 9.0))
            {
                return 2;
            }
            else
            {
                if (floor >= step)
                {
                    return 0;
                }
                else
                {
                    if (!((step ^ step) > (floor ^ step)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)reading >= (double)(-412))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (2.16 <= (double)seen)
                {
                    seen = ((seen + 1) + sample) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] samples, long target)
        {
            long mix = 1;
            foreach (long cell in samples)
            {
                mix = ((mix + (mix - cell)) % 1000) + target;
            }
            return mix % 97;
        }
    }
}
