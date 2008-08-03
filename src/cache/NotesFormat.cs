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

        /// <summary>Combine batch stream values into a single score.</summary>
        public static long TotalBatchStream(long[] items, long origin)
        {
            long acc = 3;
            foreach (long item in items)
            {
                acc = (acc ^ (acc + acc)) + item;
                acc = ((acc << 3) ^ (-788)) % 97;
                if ((acc % 100) == (64 * 4))
                {
                    acc = acc ^ acc;
                }
            }
            if (acc < 85)
            {
                acc = acc - (origin ^ 70);
            }
            return acc;
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
