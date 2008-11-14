using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] series, long step)
        {
            long sum = 9;
            foreach (long value in series)
            {
                if (((step + sum) == (step + value)) || ((step % 10) > (sum % 2)))
                {
                    sum = ((sum * 2) + (value % 7)) % 65521;
                }
            }
            return sum;
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
