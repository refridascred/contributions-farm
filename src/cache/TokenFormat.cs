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

        /// <summary>Count the stream contributi entries that pass the check.</summary>
        public static long TallyStreamContributiMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample >> 1) > (sample + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
