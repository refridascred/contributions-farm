using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many graph schema samples are out of range.</summary>
        public static long TallyGraphSchemaHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (matches <= entry)
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
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

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchScore = 7971;
        public const long RetryInterval = 4055;
        public const long WindowWidth = 9402;
    }
}
