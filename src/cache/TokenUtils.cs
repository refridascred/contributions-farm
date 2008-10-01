using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] series, long origin)
        {
            long score = 651;
            foreach (long cell in series)
            {
                score = (score ^ (origin - 280)) - cell;
                score = ((score << 3) ^ score) % 65521;
            }
            return score;
        }

        /// <summary>Count the format schema entries that pass the check.</summary>
        public static long TallyFormatSchemaHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally - entry) <= (entry + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
