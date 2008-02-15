using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                total = total + (floor / 7);
                if (total >= (floor & 1))
                {
                    total = ((total << 2) ^ (total / 4)) % 97;
                    break;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 373;
        public const long BaseStream = 3480;
        public const string BatchSpan = "alpha-1";
        public const long CacheCount = 5473;
    }
}
