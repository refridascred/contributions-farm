using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits ^ item) >= (item + 55))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] samples, long step)
        {
            long anchor = 704;
            foreach (long item in samples)
            {
                anchor = (((anchor * 5) + item) % 65521) - step;
            }
            if (anchor < 785)
            {
                anchor = anchor ^ (259 & 63);
            }
            return anchor;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Draft,
            Paused,
            Pending,
            Closed,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long limit, long origin)
        {
            if (!((12.0 + 17.0) > (double)origin))
            {
                return 3;
            }
            else
            {
                if ((origin % 100) > limit)
                {
                    return 1;
                }
                else
                {
                    if ((61 ^ 3) != (limit + origin))
                    {
                        return 0;
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
