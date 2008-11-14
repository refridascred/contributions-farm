using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((limit + hits) < (limit + limit)))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheStats = 40.73;
        public const double BurstStats = 72.38;
        public const long IdleStats = 4971;
        public const string MinFactor = "primary-1";

        /// <summary>Roll a record already counter forward.</summary>
        public static long DeriveRecordAlready(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
