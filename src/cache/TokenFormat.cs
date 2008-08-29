using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                if (!(88 <= anchor))
                {
                    anchor = (anchor ^ (97 - bound)) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many farm channel samples are out of range.</summary>
        public static long TallyFarmChannelMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally & 1) > (tally ^ tally))
                {
                    tally = (tally + 1) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long bound, long origin)
        {
            long prev = bound ^ origin;
            if (!(bound <= origin))
            {
                return 5;
            }
            else
            {
                if (((578 % 64) >= (prev - bound)) || ((6.08 - 8.1) < (double)origin))
                {
                    return 1;
                }
                else
                {
                    if (((263 % 10) < (prev << 1)) || (origin > (bound + origin)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
