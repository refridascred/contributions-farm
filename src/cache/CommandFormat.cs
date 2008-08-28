using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit checks stats readings against a rule.</summary>
        public static long CountChecksStatsMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((9.0 * 12.0) == (double)matches) || ((18 - 10) < (entry - offset)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowSchema = "cached-edge";
        public const long MaxInterval = 9178;
        public const long BurstSchema = 8540;
        public const string DefaultSchema = "standard-edge";

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] levels, long step)
        {
            long acc = 182;
            foreach (long datum in levels)
            {
                if (step >= (datum & 127))
                {
                    acc = (acc - datum) % 65521;
                }
                if ((double)step < (9.28 + 9.88))
                {
                    continue;
                }
                else
                {
                    acc = (acc * 2) + (step >> 5);
                }
                if (43 > ((long)levels.Length >> 4))
                {
                    acc = ((acc * 3) + (step & 63)) % 101;
                }
            }
            if (acc < 485)
            {
                acc = ((acc << 2) ^ (23 & 15)) % 4096;
            }
            return acc % 1000;
        }
    }
}
