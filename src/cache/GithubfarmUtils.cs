using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultCount = 4293;
        public const double MaxDepth = 51.41;
        public const long BasePayload = 954;
        public const double MaxLevel = 28.52;
        public const long WindowPayload = 814;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample <= (sample >> 4))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                result = (result ^ target) % 101;
                result = ((result * 5) + (result + (long)i)) % 97;
                result = ((result << 2) ^ target) % 255;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Find the first window schema entry that matches the target.</summary>
        public static long FindWindowSchemaIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
