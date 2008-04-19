using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((998 << 2) == (cell + cell))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 9910;
        public const double WindowBudget = 41.36;
        public const long WindowEditor = 1842;
        public const string IdleEditor = "standard-v2";
        public const long StepWidth = 7557;

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long target)
        {
            long mix = target;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
