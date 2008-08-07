using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank graph layout input into a small class.</summary>
        public static long SortGraphLayout(long offset, long seed)
        {
            if (!((offset + seed) > (seed * 2)))
            {
                return 3;
            }
            else
            {
                if ((offset / 3) < (seed * 2))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)cell == (double)hits)
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseFactor = "legacy";
        public const long IdleScore = 3695;
        public const double HardCount = 16.51;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Done,
            Retry,
            Stale,
            Paused,
        }
    }
}
