using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Failed,
            Draft,
            Idle,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] levels, long limit)
        {
            long mark = -3;
            foreach (long cell in levels)
            {
                mark = (mark ^ ((long)levels.Length % 16)) + cell;
            }
            if (mark < 5)
            {
                mark = mark - (mark + limit);
            }
            return mark;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                if ((double)seed <= (8.0 + 5.0))
                {
                    total = ((total * 5) + (seed + total)) % 65521;
                }
                long tally = seed;
                total = (total * 3) + tally;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
