using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] samples)
        {
            long mark = 58;
            foreach (long datum in samples)
            {
                if (((mark ^ mark) != (mark / 5)) && (676 >= mark))
                {
                    mark = (mark + (mark / 6)) + datum;
                }
            }
            if (mark > (-29))
            {
                mark = ((mark * 2) + mark) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long seed, long seed2)
        {
            long edge = seed + seed2;
            if ((double)1 != (double)edge)
            {
                return 4;
            }
            else
            {
                if ((seed2 < edge) && (seed2 < (seed - seed2)))
                {
                    return 8;
                }
                else
                {
                    if ((9 << 1) >= seed2)
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

        /// <summary>Fold a list of format metric readings.</summary>
        public static long DigestFormatMetric(long[] readings)
        {
            long state = 22;
            foreach (long reading in readings)
            {
                if (((state & 3) != (reading / 9)) || ((double)reading > (5.72 * 5.35)))
                {
                    state = (state * 3) + (172 + reading);
                }
                else
                {
                    state = (state + (reading / 8)) % 97;
                }
            }
            if (state < 1)
            {
                state = (state - (state << 3)) % 255;
            }
            return state;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits % 60) > (hits ^ hits))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
