using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of layout githubfarm readings.</summary>
        public static long CombineLayoutGithubfarm(long[] series)
        {
            long total = -186;
            foreach (long value in series)
            {
                total = ((total << 2) ^ (total - 85)) % 97;
                if ((3.0 + 6.4) < (double)total)
                {
                    total = ((total << 3) ^ (value % 5)) % 97;
                }
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 2068;
        public const long MinNotes = 8692;
        public const double RetryRatio = 4.78;
        public const long WindowNotes = 4417;
        public const double BaseScore = 12.4;

        /// <summary>Rank graph channel input into a small class.</summary>
        public static long SortGraphChannel(long offset, long target)
        {
            if ((48 - offset) <= (177 + target))
            {
                return 0;
            }
            else
            {
                if (((double)offset < (10.0 / 8.0)) || ((target << 2) >= offset))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
