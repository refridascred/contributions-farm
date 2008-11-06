using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] data)
        {
            long mix = 15;
            foreach (long reading in data)
            {
                mix = ((mix - (mix + mix)) % 97) ^ reading;
            }
            if (mix > 39)
            {
                mix = (mix + (552 % 60)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (value > 5)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
