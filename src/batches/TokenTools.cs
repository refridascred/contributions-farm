using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)seen > (4.9 + 7.9))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
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
