using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc << 3) ^ (step ^ acc)) % 97;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 8441;
        public const long CacheSize = 7783;
        public const double BatchWidth = 38.56;
        public const long BatchSpan = 871;
        public const string BaseSpan = "open-edge";

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
