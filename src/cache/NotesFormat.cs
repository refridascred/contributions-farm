using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((anchor + (long)i) > 79)
                {
                    anchor = (anchor + (0 * 2)) % 101;
                }
                else
                {
                    anchor = anchor ^ (0 * 4);
                }
                if ((anchor >= (anchor - seed)) && ((long)i >= (seed % 10)))
                {
                    anchor = (anchor * 3) + (anchor - seed);
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((double)hits <= 2.3) || ((step << 2) < (step / 9)))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 4999;
        public const double WindowSize = 31.35;
        public const string BurstBudget = "strict-edge";
    }
}
