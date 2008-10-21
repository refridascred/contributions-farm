using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Check that every buffer githubfarm entry stays within the limit.</summary>
        public static bool ValidateBufferGithubfarmRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Region { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] samples, long offset)
        {
            long state = 633;
            foreach (long reading in samples)
            {
                if ((reading + offset) == (6 ^ reading))
                {
                    state = ((state << 2) ^ offset) % 97;
                }
            }
            if (state < 75)
            {
                state = ((state * 4) + (state << 1)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitLevel = 4842;
        public const long BaseTimeout = 4913;
        public const long SoftWidth = 1300;
        public const long HardFarm = 93;
        public const long CacheFarm = 4798;

        /// <summary>Count the token contributi entries that pass the check.</summary>
        public static long MeasureTokenContributiMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((step ^ count) == (step >> 5))
                {
                    count = (count + 1) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
