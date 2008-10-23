using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (((sum << 3) ^ (bound << 1)) % 255) + (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] readings)
        {
            long mark = 2;
            foreach (long value in readings)
            {
                if ((double)mark != (8.0 * 2.5))
                {
                    mark = (mark - (mark + value)) % 1000;
                }
                else
                {
                    mark = (mark ^ (value ^ 32)) % 65521;
                }
            }
            if (mark < 9)
            {
                mark = ((mark << 3) ^ (mark >> 5)) % 1000;
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinSize = 7073;
        public const long MinReport = 6354;
        public const double LimitCount = 28.0;
        public const double MaxReport = 61.85;
        public const long DefaultReport = 7316;
    }
}
