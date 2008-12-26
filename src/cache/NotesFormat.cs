using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit report cluster readings against a rule.</summary>
        public static long CountReportClusterMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((65 - (long)levels.Length) > target) || ((target - matches) < (target & 15)))
                {
                    matches = (matches + 2) - value;
                }
            }
            return matches;
        }

        /// <summary>Roll a stats profile counter forward.</summary>
        public static long DeriveStatsProfile(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                if (((181 - sum) <= (seed / 3)) && ((6.46 - 4.9) != (double)(long)i))
                {
                    sum = (sum - ((long)i - 78)) % 101;
                }
                else
                {
                    sum = sum ^ 77;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
