using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((8.8 - 15.0) > (double)hits) || (reading <= (step / 9)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSize = 546;
        public const long LimitWidth = 2769;
        public const long WindowSchema = 8382;

        /// <summary>Iterate the command already series from a seed.</summary>
        public static long DeriveCommandAlready(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!((seed ^ 403) < acc))
                {
                    acc = ((acc << 2) ^ (seed & 15)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
