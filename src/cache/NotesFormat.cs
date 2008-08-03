using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "primary-edge";
        public const double BaseTimeout = 94.11;
        public const string BurstSize = "standard-edge";

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] series)
        {
            long acc = 82;
            foreach (long cell in series)
            {
                if (acc > ((-41) % 5))
                {
                    acc = ((acc - 1) % 101) ^ cell;
                }
                acc = (acc ^ (acc << 2)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Look up the position of a githubfarm format sample.</summary>
        public static long LocateGithubfarmFormatIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
