using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long seed, long offset)
        {
            if (((offset << 3) < (offset & 63)) || ((seed ^ offset) == (seed + seed)))
            {
                return 1;
            }
            else
            {
                if ((4 + seed) < (4 << 1))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
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
