using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                long count = score;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = (((score * 5) + ((-713) + count)) % 97) ^ (long)i2;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Compare every pair of account stream readings.</summary>
        public static long OverlapAccountStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count schema order pairs that satisfy a relation.</summary>
        public static long PairSchemaOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Locked,
            Failed,
            Queued,
            Draft,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxWidth = "latest-v2";
        public const double IdleLevel = 19.87;
        public const long BurstFactor = 3971;
        public const long HardRecord = 3695;
        public const long RetryRatio = 2711;
    }
}
