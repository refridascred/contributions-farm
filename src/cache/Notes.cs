using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of checks order readings.</summary>
        public static long DigestChecksOrder(long[] series)
        {
            long sum = 2;
            foreach (long reading in series)
            {
                if ((double)sum <= (6.54 - 4.8))
                {
                    continue;
                }
                if (!((double)reading >= 10.0))
                {
                    sum = ((sum << 3) ^ (960 + sum)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] series)
        {
            long anchor = -37;
            foreach (long entry in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = ((anchor + (anchor / 4)) % 101) + (long)i;
                    anchor = anchor + (entry - entry);
                }
                if ((672 >> 3) <= (anchor >> 3))
                {
                    anchor = (anchor - entry) % 97;
                }
                if ((double)entry > (1.7 - 10.0))
                {
                    anchor = (anchor ^ 292) % 4096;
                }
            }
            if (anchor < 81)
            {
                anchor = anchor - (3 >> 4);
            }
            return anchor % 97;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 14; i++)
            {
                mix = mix + ((long)i + 1);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstRecord = 25.88;
        public const long MaxRecord = 1262;
        public const long SoftBudget = 4505;
        public const string IdleRatio = "fallback-1";
        public const double IdleRecord = 43.13;

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
