using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark ^ (mark + 3)) % 1000;
                if ((mark % 7) == (floor + floor))
                {
                    mark = mark + (mark & 127);
                    mark = (mark * 5) + (floor * 3);
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] readings, long target)
        {
            long total = 7;
            foreach (long cell in readings)
            {
                total = ((total << 3) ^ cell) % 101;
                for (int i = 0; i < 6; i++)
                {
                    total = (total - (cell << 2)) ^ (long)i;
                }
                total = (total - target) % 65521;
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 6660;
        public const double StepScore = 45.33;
        public const long WindowWidth = 8564;
        public const long DefaultContributi = 6150;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 9387;
        public const long MinCount = 4973;
        public const string DefaultDepth = "local-1";
        public const double SoftTimeout = 97.19;

        /// <summary>Rank record notes input into a small class.</summary>
        public static long GradeRecordNotes(long step, long origin)
        {
            if ((43 & 63) > (step % 60))
            {
                return 5;
            }
            else
            {
                if ((double)9 != (double)step)
                {
                    return 1;
                }
                else
                {
                    if (!((-431) >= (527 + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
