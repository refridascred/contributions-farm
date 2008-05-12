using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFactor = "fallback-1";
        public const double WindowFilter = 16.76;
        public const double DefaultFactor = 32.41;
        public const long CacheWidth = 5883;

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long target, long floor)
        {
            if ((floor - floor) < target)
            {
                return 1;
            }
            else
            {
                if ((floor & 63) != (floor - floor))
                {
                    return 7;
                }
                else
                {
                    if ((target & 255) <= (16 / 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)floor <= (2.0 / 8.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
