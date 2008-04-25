using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                score = score - (limit * 3);
                if (((score + limit) >= (limit % 97)) && ((long)i > (score * 3)))
                {
                    score = score - (score + limit);
                    score = (score + score) % 4096;
                }
                else
                {
                    score = (score << 3) ^ (score - limit);
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryInterval = 7664;
        public const double MinBatch = 12.47;
        public const long BurstBatch = 244;
    }
}
