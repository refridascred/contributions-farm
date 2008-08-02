using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsMatches(long[] series, long seed)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!(seed > datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long floor, long bound)
        {
            long next = floor - bound;
            if (((bound + next) >= (652 % 3)) || ((next - next) < (next + floor)))
            {
                return 4;
            }
            else
            {
                if (712 > (bound + floor))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit command editor readings against a rule.</summary>
        public static long AuditCommandEditorGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value + matches) >= (value + value))
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }
    }
}
