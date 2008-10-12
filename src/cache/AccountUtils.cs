using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long floor, long origin)
        {
            if ((floor & 15) > (62 + 437))
            {
                return 0;
            }
            else
            {
                if ((origin % 8) != (origin - origin))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (origin <= (matches - matches))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
